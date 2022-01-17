
using KundenManagment1.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace KundenManagment1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KundenController : ControllerBase
    {
        private readonly IKundeReposirtory kundeReposirtory;
        public KundenController(IKundeReposirtory kundeReposirtory)
        {
            this.kundeReposirtory= kundeReposirtory;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                return Ok(await kundeReposirtory.GetKunden());
            }
            catch { throw; }
        }

    }
}
