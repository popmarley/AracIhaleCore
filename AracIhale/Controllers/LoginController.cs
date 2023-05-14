using AracIhale.UI.Models.VM;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http.Json;

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
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Login(Kullanici model)
		{
			var response = await _httpClient.PostAsJsonAsync("http://localhost:36989/api/Login", model);

			if (response.IsSuccessStatusCode)
			{
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
	}
}
