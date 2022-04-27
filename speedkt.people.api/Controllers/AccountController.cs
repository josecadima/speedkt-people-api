using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using speedkt.people.data.Model;
using speedkt.people.data.Service;

namespace speedkt.people.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private IAccountService accountService;
        private readonly ILogger<PersonController> logger;

        public AccountController(ILogger<PersonController> logger, IAccountService accountService)
        {
            this.logger = logger;
            this.accountService = accountService;
        }

        [HttpGet]
        public IActionResult Get(string auth0Id)
        {
            Account account = null;
            try
            {
                account = accountService.GetByAuth0Id(auth0Id);
            }
            catch(Exception ex)
            {
                //TODO log
                return BadRequest("Failed searching account");
            }

            if (account == null)
                return NotFound();

            return Ok(account);
        }
    }
}
