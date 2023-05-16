using AracIhale.UI.Models.VM;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Http;
using System;
using AracIhale.UI.Models.Extension;

namespace AracIhale.UI.Controllers
{
    public class LoginController : Controller
    {

		private readonly HttpClient _httpClient;

		public LoginController(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public IActionResult Login()
        {
			var model = new Kullanici();

			if (Request.Cookies.ContainsKey("username"))
			{
				model.KullaniciAdi = Request.Cookies["username"];
			}

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Login(Kullanici model, bool rememberMe)
		{
			var response = await _httpClient.PostAsJsonAsync("http://localhost:36989/api/Login", model);

			if (response.IsSuccessStatusCode)
			{
                Kullanici user = await response.Content.ReadFromJsonAsync<Kullanici>();

				HttpContext.Session.MySessionSet("RolID", user.RolID);

				if (rememberMe)
				{
					// Kullanıcı adını çerezlere kaydediyoruz
					CookieOptions options = new CookieOptions();
					options.Expires = DateTime.Now.AddDays(30); // Çerezin 30 gün boyunca geçerli olmasını sağlıyoruz
					Response.Cookies.Append("username", model.KullaniciAdi, options);
				}
				
				HttpContext.Session.MySessionSet("Ad", model.KullaniciAdi);// Kullanıcı adını bir Session'a kaydediyoruz

				// Giriş başarılı oldu, kullanıcıyı Ihale/AracListeleme sayfasına yönlendir
				return RedirectToAction("AracListeleme", "Ihale");
			}
			else
			{
				// Giriş başarısız oldu, hata mesajını göster ve kullanıcıyı geri yönlendir
				ModelState.AddModelError(string.Empty, "Invalid login attempt.");
				return View(model);
			}

		}

		public IActionResult Logout()
		{
			//Response.Cookies.Delete("username"); // Kullanıcı adı çerezini siliyoruz
			//HttpContext.Session.Clear(); // Tüm oturum verilerini siliyoruz

			return RedirectToAction("Login"); // Kullanıcıyı giriş sayfasına yönlendiriyoruz
		}
	}
}
