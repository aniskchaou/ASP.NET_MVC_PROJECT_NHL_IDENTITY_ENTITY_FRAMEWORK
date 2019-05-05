using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace first_primer.Models.NHL
{
    public class Team
    {
        public Team()
        {

        }
        public Team(string teamName, string city, string province)
        {
            TeamName = teamName;
            City = city;
            Province = province;
        }

        //primary key
        [Key]
        [MaxLength(30)]
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        public List<Player> Players { get; set; }
    }
}