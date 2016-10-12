namespace TourPoc.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public sealed class Configuration : DbMigrationsConfiguration<TourPoc.Data.ApplicationIdentityDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TourPoc.Data.ApplicationIdentityDbContext context)
        {
            this.SeedRoles(context);
            this.SeedAministrators(context);
        }

        private void SeedRoles(ApplicationIdentityDbContext context)
        {
            if (context.Roles.Any())
            {
                return;
            }

            context.Roles.Add(new IdentityRole
            {
                Name = "admin"
            });

            context.SaveChanges();
        }

        private void SeedAministrators(ApplicationIdentityDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var adminRole = context.Roles.FirstOrDefault(x => x.Name.ToLower() == "admin");

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var admin = new ApplicationUser { UserName = "admin", Email = "admin@admin.com" };

            userManager.Create(admin, "123456");
            context.SaveChanges();

            userManager.AddToRole(admin.Id, "admin");
            context.SaveChanges();
        }
    }
}
