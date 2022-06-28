using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TariffController : ControllerBase
    {
        private readonly StoreContext _context;

        public TariffController(StoreContext context)
        {
            _context = context;
        }
        [HttpGet] 
        public async Task<ActionResult<List<Tariff>>> GetTariffs ()
        {
            List<Tariff> tariffs = await _context.Tariffs.ToListAsync();
            return Ok(tariffs);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Tariff>> GetTariff(int id)
        {
            Tariff tariff = await _context.Tariffs.FindAsync(id);
            return Ok(tariff);
            return Ok();
        }
    }
}
