using PatchInsteadPut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatchInsteadPut.Services
{
    public class TeamService
    {
        public List<Team> GetTeams()
        {
            return InMemoryTeamsAndPlayers.GetTeamsInMemory();
        }
    }
}
