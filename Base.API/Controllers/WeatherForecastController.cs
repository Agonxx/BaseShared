using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Base.API.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController() { }

        [HttpGet]
        public async Task<IActionResult> GetTestAsync()
        {
            return Ok();
        }
    }
}
