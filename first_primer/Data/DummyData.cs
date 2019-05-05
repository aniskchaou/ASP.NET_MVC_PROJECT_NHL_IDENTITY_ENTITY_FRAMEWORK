using first_primer.Models.NHL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace first_primer.Data
{
    public class DummyData
    {

      public static  List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team("a","qdsf","sdf")
            };

            return teams;
        }


     public static   List<Player> getPlayers(NHLContext nhl)
        {
            List<Player> players = new List<Player>()
            {
                new Player("qsd","qsd","qsd",nhl.Teams.Find("a").TeamName)
            };

            return players;
        }
    }
}