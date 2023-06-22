using Microsoft.AspNetCore.Mvc;

namespace Practical_16_core.Controllers
{
    
        [ApiController]
        [Route("[controller]")]
        public class HelloWorldController : ControllerBase
        {
            private readonly ILogger<HelloWorldController> _logger;

            public HelloWorldController(ILogger<HelloWorldController> logger)
            {
                _logger = logger;
            }

            [HttpGet]
            public IActionResult Get()
            {
                _logger.LogInformation("Hello World API was called.");
                return Ok("Hello, World!");
            }
        }
}
