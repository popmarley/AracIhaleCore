using AracIhale.API.DTO;
using AracIhale.API.MyContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AracIhale.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AracController : ControllerBase
    {
        private readonly MyDBContext _context;

        public AracController(MyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Araclar>>> GetAraclar()
        {
            var araclar = await _context.Araclar.ToListAsync();
            return araclar;
        }

        // GET: api/Arac/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Araclar>> GetArac(int id)
        {
            var arac = await _context.Araclar.FindAsync(id);

            if (arac == null)
            {
                return NotFound();
            }

            return arac;
        }


    }
}
