using Homework2.AspectOrianted.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.AspectOrianted.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [PerformanceAspect]
        public async Task<IActionResult> Get()
        {
            await Task.Delay(200);

            return Ok();
        }
    }
}
