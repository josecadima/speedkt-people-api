using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using speedkt.people.api.Model;
using speedkt.people.data.Model;
using speedkt.people.data.Service;

namespace speedkt.people.api.Controllers
{
    [Authorize]
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

        [HttpGet]
        [Route("list")]
        public IEnumerable<Person> GetAll()
        {
            return personService.GetAll();
        }

        [HttpGet]
        [Route("{personId:guid}")]
        public Person Get(Guid personId)
        {
            return personService.GetById(personId);
        }

        [HttpPut]
        [Route("info")]
        public void UpdateBasicInfo(Person personInfo)
        {
            personService.UpdateBasicInfo(personInfo);
        }

        [HttpPut]
        [Route("avatar")]
        public void UpdateAvatarAsync(AvatarInfo info)
        {
            personService.UpdateAvatar(info.PersonId, info.ImageData);
        }
    }
}