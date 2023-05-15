using AracIhale.UI.Models.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AracIhale.UI.Controllers
{
    public class IhaleController : Controller
    {

		private readonly APIGateway _apiGateway;

		public IhaleController(APIGateway apiGateway)
		{
			_apiGateway = apiGateway;
		}

		public async Task<IActionResult> AracListeleme()
		{
			var ihaleler = await _apiGateway.ListIhale();
			return View(ihaleler);
		}

		public IActionResult AracIhaleOlusturma()
		{
			return View();
		}

		[HttpGet]
        public IActionResult Create()
        {
            IhaleListesi ihaleler = new IhaleListesi();
            return View(ihaleler);
        }
        [HttpPost]
        public IActionResult Create(IhaleListesi ihale)
        {
            _apiGateway.CreateIhale(ihale);
            return RedirectToAction("AracListeleme");

        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _apiGateway.DeleteIhale(id);
            if (result)
            {
                return RedirectToAction("AracListeleme");
            }
            else
            {
                return View("Error");
            }
        }

    }
}
    

