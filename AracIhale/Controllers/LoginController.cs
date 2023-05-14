using Microsoft.AspNetCore.Mvc;

namespace AracIhale.UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
