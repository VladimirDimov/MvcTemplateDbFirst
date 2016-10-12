namespace TourPoc.Data
{
    using System.Data.Entity;
    using System.Linq;
    using Microsoft.AspNet.Identity;

    public class DatabaseInitializer : CreateDatabaseIfNotExists<ApplicationIdentityDbContext>
    {
        public override void InitializeDatabase(ApplicationIdentityDbContext context)
        {
            this.Seed(context);
        }

        protected override void Seed(ApplicationIdentityDbContext context)
        {
            this.SeedAministrators(context);
        }

        private void SeedAministrators(ApplicationIdentityDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            context.Users.Add(new ApplicationUser
            {
                Email = "admin@admin.com",
                UserName = "admin",
                PasswordHash = new PasswordHasher().HashPassword("admin")
            });

            context.SaveChanges();
        }
    }
}
