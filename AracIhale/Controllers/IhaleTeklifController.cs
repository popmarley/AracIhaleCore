using AracIhale.UI.Models.VM;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AracIhale.UI.Controllers
{
    public class IhaleTeklifController : Controller
    {
        private readonly APIGateway _apiGateway;

        public IhaleTeklifController(APIGateway apiGateway)
        {
            _apiGateway = apiGateway;
        }
        
        [HttpGet]
        public async Task<IActionResult> TeklifVer(int id)
        {

            BireyselAracTeklif ihaleteklif = await _apiGateway.GetIhaleTeklif(id);
            if (ihaleteklif == null)
            {
                return NotFound();
            }
            return View(ihaleteklif);
        }

        [HttpPost]
        public async Task<IActionResult> TeklifVer(BireyselAracTeklif ihaleTeklif)
        {
            if (ModelState.IsValid)
            {
                await _apiGateway.CreateIhaleTeklif(ihaleTeklif);
                return RedirectToAction("AracListeleme","Ihale");
            }
            return View(ihaleTeklif);
        }


        [HttpGet]
        public async Task<IActionResult> Teklifler()
        {
            var ihaleler = await _apiGateway.ListIhaleTeklif();
            return View(ihaleler);
        }



        public async Task<IActionResult> DeleteTeklif(int id)
        {
            var result = await _apiGateway.DeleteIhaleTeklif(id);
            if (result)
            {
                return RedirectToAction("Teklifler");
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> EditTeklif(int id)
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

