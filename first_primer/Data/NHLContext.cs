using first_primer.Models.NHL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace first_primer.Data
{
    public class NHLContext:DbContext
    {
        public NHLContext():base("DefaultConnection")
        {
                
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}