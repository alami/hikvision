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
    public class TariffsController : ControllerBase
    {
        private readonly ITariffRepository _repo;

        public TariffsController(ITariffRepository repo)
        {
            _repo = repo;
        }
        [HttpGet] 
        public async Task<ActionResult<IReadOnlyList<Tariff>>> GetTariffs ()
        {
            IReadOnlyList <Tariff> tariffs = await _repo.GetTariffsAsync();
            return Ok(tariffs);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Tariff>> GetTariff(int id)
        {
            return await _repo.GetTariffByIdAsync(id);            
        }
        [HttpGet("Resolutions")]
        public async Task<ActionResult<Resolution>> GetResolutions()
        {
            return Ok(await _repo.GetResolutionsAsync());
        }
        [HttpGet("Periods")]
        public async Task<ActionResult<Period>> GetPeriods()
        {
            return Ok(await _repo.GetPeriodsAsync());
        }
    }
}
