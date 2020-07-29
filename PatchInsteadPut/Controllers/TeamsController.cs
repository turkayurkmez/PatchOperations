using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatchInsteadPut.Services;

namespace PatchInsteadPut.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        public IActionResult Get()
        {
            var teams = new TeamService().GetTeams();
            return Ok(teams);
        }
    }
}
