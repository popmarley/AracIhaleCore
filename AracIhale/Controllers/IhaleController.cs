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



        //public IActionResult Index()
        //{
        //    List<IhaleListesi> ihaleler = new List<IhaleListesi>();
        //    return View(ihaleler);
        //}

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(IhaleListesi ihale)
        //{
        //    if (ModelState.IsValid)
        //    {
        //     var hede=   await _apiGateway.CreateIhale(ihale);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(ihale);
        //}

        //    [HttpGet]
        //    public async Task<IActionResult> Edit(int id)
        //    {
        //        var ihale = await _apiGateway.GetIhaleById(id);
        //        if (ihale == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(ihale);
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> Edit(int id, IhaleListesi ihale)
        //    {
        //        if (id != ihale.IhaleID)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            await _apiGateway.UpdateIhale(ihale);
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(ihale);
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> Delete(int id)
        //    {
        //        var ihale = await _apiGateway.GetIhaleById(id);
        //        if (ihale == null)
        //        {
        //            return NotFound();
        //        }
        //        await _apiGateway.DeleteIhale(ihale.IhaleID);
        //        return RedirectToAction(nameof(Index));
        //    }


    }
}
    

