namespace first_primer.Migration.NHL
{
    using Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<first_primer.Data.NHLContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migration\NHL";
        }

        protected override void Seed(first_primer.Data.NHLContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Teams.AddOrUpdate(t => t.TeamName, DummyData.getTeams().ToArray());

            context.Players.AddOrUpdate(p => new { p.FirstName,p.LastName}, DummyData.getPlayers(context).ToArray());
        }
    }
}
