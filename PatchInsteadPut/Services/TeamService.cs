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

        public Team GetTeam(int id)
        {
            return InMemoryTeamsAndPlayers.GetTeamsInMemory().FirstOrDefault(x => x.Id == id);
        }

        public Team Edit(Team team)
        {
            var existingTeam = GetTeam(team.Id);
            if (existingTeam != null)
            {
                existingTeam.LogoUrl = team.LogoUrl;
                existingTeam.Name = team.Name;
                existingTeam.Players = team.Players;
                
            }

            return existingTeam;

        }
    }
}
