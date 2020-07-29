using PatchInsteadPut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatchInsteadPut.Services
{
    public class InMemoryTeamsAndPlayers
    {
        public static List<Team> GetTeamsInMemory()
        {
            return new List<Team>
            {
                 new Team
                 {
                      Name = "Beşiktaş JK",
                      Players = new List<Player>
                      {
                          new Player{
                                     Name ="Utku Yuvakuran",
                                     BirthDate = new DateTime(1997,11,2),
                                     Nationality="Türkiye",
                                     Position ="Kaleci"
                                    },
                          new Player { Name="Ersin Destanoğlu",
                                       BirthDate = new DateTime(2001,1,1),
                                       Nationality ="Türkiye",
                                       Position = "Kaleci"
                                     },
                           new Player { Name="Domagoj Vida",
                                       BirthDate = new DateTime(1989,4,29),
                                       Nationality ="Türkiye",
                                       Position = "Stoper"
                                     }
                      }

                 },
                     new Team
                 {
                      Name = "Galatasaray SK",
                      Players = new List<Player>
                      {
                          new Player{
                                     Name ="Fernando Muslera",
                                     BirthDate = new DateTime(1986,6,16),
                                     Nationality="Türkiye",
                                     Position ="Kaleci"
                                    },
                          new Player { Name="Okan Kocuk",
                                       BirthDate = new DateTime(1995,7,27),
                                       Nationality ="Türkiye",
                                       Position = "Stoper"
                                     },
                           new Player { Name="Christian Luyindama",
                                       BirthDate = new DateTime(1994,1,8),
                                       Nationality ="Kongo",
                                       Position = "Kaleci"
                                     }
                      }

                 }

            };
        }
    }
}
