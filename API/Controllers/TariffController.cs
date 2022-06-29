using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Repository.IRepository;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TariffController : ControllerBase
    {
        private readonly ITariffRepository _repo;

        public TariffController(ITariffRepository repo)
        {
            _repo = repo;
        }
        [HttpGet] 
        public async Task<ActionResult<IReadOnlyList<Tariff>>> GetTariffs ()
        {
            IReadOnlyList <Tariff> tariffs = await _repo.GetTariffAsync();
            return Ok(tariffs);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Tariff>> GetTariff(int id)
        {
            Tariff tariff = await _repo.GetTariffByIdAsync(id);
            return Ok(tariff);
        }
    }
}
