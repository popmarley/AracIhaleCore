using AracIhale.API.DTO;
using AracIhale.API.MyContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AracIhale.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		private readonly MyDBContext _context;

		public LoginController(MyDBContext context)
		{
			_context = context;
		}

		[HttpPost]
		public async Task<IActionResult> Login(Kullanici kullanici)
		{
            var user = await _context.Kullanici
                 .FirstOrDefaultAsync(u => u.KullaniciAdi == kullanici.KullaniciAdi && u.Sifre == kullanici.Sifre);

            if (user == null)
            {
                return Unauthorized(); // Kullanıcı adı veya şifre yanlışsa 401 Unauthorized döner
            }

            return Ok(user);
        }
	}
}
