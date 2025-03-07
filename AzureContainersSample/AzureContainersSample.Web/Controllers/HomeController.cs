using Microsoft.AspNetCore.Mvc;

namespace AzureContainersSample.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(new { Message = "Hello World", Date = DateTime.Now });
        }
    }
}
