using Microsoft.AspNetCore.Mvc;
using speedkt.people.data.Model;
using speedkt.people.data.Service;

namespace speedkt.people.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonService personService;

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger,
            IPersonService personService)
        {
            _logger = logger;

            this.personService = personService;
        }

        [HttpGet(Name = "all")]
        public IEnumerable<Person> GetAll()
        {
            return personService.GetAll();
        }
    }
}