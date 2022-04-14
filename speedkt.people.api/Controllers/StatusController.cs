using Microsoft.AspNetCore.Mvc;

namespace speedkt.people.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly ILogger<PersonController> logger;

        public StatusController(ILogger<PersonController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Up & running!";
        }
    }
}