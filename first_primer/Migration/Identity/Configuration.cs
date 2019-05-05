namespace first_primer.Migration.Identity
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<first_primer.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migration\Identity";
        }

        protected override void Seed(first_primer.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("Administrator"))
                roleManager.Create(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole("Administrator"));

            if (!roleManager.RoleExists("Guest"))
                roleManager.Create(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole("Guest"));

            var userManager = new UserManager<ApplicationUser>(new Microsoft.AspNet.Identity.EntityFramework.UserStore<ApplicationUser>(new ApplicationDbContext()));
            string[] emails = { "admin@live.fr","guest@live.fr" };
            if (userManager.FindByEmail(emails[0])==null)
            {
                var user = new ApplicationUser
                {
                    Email = emails[0],
                    UserName = emails[0]
                };
                var result = userManager.Create(user, "admin");

                if(result.Succeeded)
                {
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Administrator");
                }
            }



            if (userManager.FindByEmail(emails[1]) == null)
            {
                var user = new Models.ApplicationUser
                {
                    Email = emails[1],
                    UserName = emails[1]
                };
                var result = userManager.Create(user, "guest");

                if (result.Succeeded)
                {
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Guest");
                }
            }

        }
    }
}
