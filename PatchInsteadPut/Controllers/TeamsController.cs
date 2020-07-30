using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using PatchInsteadPut.Models;
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

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Team team)
        {
            TeamService teamService = new TeamService();
            if (teamService.GetTeam(id) == null)
            {
                return BadRequest();
            }
            Team updatedTeam = teamService.Edit(team);
            return Ok(updatedTeam);
        }
    

        [HttpPatch("{id}")]
        public IActionResult Patch(int id,JsonPatchDocument<Team> patchDocument)
        {
            if (patchDocument == null)
            {
                return BadRequest(ModelState);
            }

            var team = new TeamService().GetTeam(id);
            if (team == null)
            {
                return NotFound();
            }

            patchDocument.ApplyTo(team,ModelState);
            if (ModelState.IsValid)
            {
                return Ok(team);
            }

            return BadRequest(ModelState);
        }

       
    }
}
