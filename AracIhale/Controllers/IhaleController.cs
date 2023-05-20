using AracIhale.UI.Models.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult AracIhaleTeklifVerme()
        {
            return View();
        }

		public async Task<IActionResult> IhaleListeleme()
		{
            var ihaleler = await _apiGateway.ListIhale();
            return View(ihaleler);
        }

		[HttpGet]
        public IActionResult Create()
        {
            IhaleListesiVM ihaleler = new IhaleListesiVM();
            return View(ihaleler);
        }
        [HttpPost]
        public IActionResult Create(IhaleListesiVM ihale)
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            IhaleListesiVM ihaleler = await _apiGateway.GetIhale(id);
            if (ihaleler == null)
            {
                return NotFound();
            }
            return View(ihaleler);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(IhaleListesiVM ihaleler)
        {
            if (ModelState.IsValid)
            {
                bool isSuccess = await _apiGateway.UpdateIhale(ihaleler);
                if (isSuccess)
                {

                    return RedirectToAction("AracListeleme");
                }
                else
                {

                    ModelState.AddModelError("", "Duzenleme islemi basarısız oldu.");
                }
            }
            return View(ihaleler);
        }

		[HttpPost]
		public async Task<IActionResult> Listele(IhaleListesiVM ihale, string ihaleAdi, int aracTuru, int aracDurumu)
		{
			List<IhaleListesiVM> ihaleler = await _apiGateway.ListIhale();

			if (!string.IsNullOrEmpty(ihaleAdi))
			{
				ihaleler = ihaleler.Where(i => i.IhaleAdi == ihaleAdi).ToList();
			}

			if (aracTuru != 0)
			{
				ihaleler = ihaleler.Where(i => i.BireyselKurumsalID == aracTuru).ToList();
			}

			if (aracDurumu != 0)
			{
				ihaleler = ihaleler.Where(i => i.IhaleStatuID == aracDurumu).ToList();
			}

			return View("AracListeleme", ihaleler);
        }

        [HttpPost]
        public async Task<IActionResult> IhaleListeFiltrele(IhaleListesiVM ihale, string ihaleAdi, int aracTuru, int aracDurumu)
        {
            List<IhaleListesiVM> ihaleler = await _apiGateway.ListIhale();

            if (!string.IsNullOrEmpty(ihaleAdi))
            {
                ihaleler = ihaleler.Where(i => i.IhaleAdi == ihaleAdi).ToList();
            }

            if (aracTuru != 0)
            {
                ihaleler = ihaleler.Where(i => i.BireyselKurumsalID == aracTuru).ToList();
            }

            if (aracDurumu != 0)
            {
                ihaleler = ihaleler.Where(i => i.IhaleStatuID == aracDurumu).ToList();
            }

            return View("IhaleListeleme", ihaleler);
        }

    }
}
    

