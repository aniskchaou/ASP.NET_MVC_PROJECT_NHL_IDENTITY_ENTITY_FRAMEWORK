using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace first_primer.Models.NHL
{
    public class Player
    {
        //key ...ID automatically
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        //Salary

        public string TeamName { get; set; }
        public Team Team { get; set; }

        public Player()
        {

        }

        public Player(string firstName, string lastName, string position, string teamName )
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            TeamName = teamName;
           
        }
    }
}