using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TariffController : ControllerBase
    {
        [HttpGet] 
        public string GetTariffs ()
        {
            return "List of tariffs";
        }
        [HttpGet("{id}")]
        public string GetTariff(int id)
        {
            return "single tariffs";
        }
    }
}
