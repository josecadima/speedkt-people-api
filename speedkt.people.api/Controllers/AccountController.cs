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
    public class AccountController : ControllerBase
    {
        private IAccountService accountService;
        private readonly ILogger<PersonController> logger;

        public AccountController(ILogger<PersonController> logger, IAccountService accountService)
        {
            this.logger = logger;
            this.accountService = accountService;
        }

        [HttpPost]
        [Route("check")]
        public IActionResult CheckAccount(AccountInfo accountInfo)
        {
            Account account = null;
            try
            {
                account = accountService.GetByAuth0Id(accountInfo.Auth0Id);
            }
            catch (Exception ex)
            {
                //TODO log
                return BadRequest("Failed searching account");
            }

            if (account == null)
                return NoContent();

            return Ok(account);
        }
    }
}
