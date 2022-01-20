﻿
using KundenManagment1.Server.Models;
using KundenManagment1.Shared;
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
                //return Ok(await kundeReposirtory.GetKunden());
                var result = await kundeReposirtory.GetKunden();
                return Ok(result);
            }
            catch { throw; }
        }
        [HttpGet("{id}")]
         public async Task<ActionResult<Dept>>GetDept(int id)
        {
            return Ok(await kundeReposirtory.GetDept( id));
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<Kunde>> GetKdById(int id)
        {
            //return Ok(await kundeReposirtory.GetKdById(id));
            var result = await kundeReposirtory.GetKdById(id);
            return Ok(result);
        }
    }
}
