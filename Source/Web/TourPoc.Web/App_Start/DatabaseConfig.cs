namespace TourPoc.Web.App_Start
{
    using System.Data.Entity;
    using Data;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationIdentityDbContext, TourPoc.Data.Migrations.Configuration>());
            ApplicationIdentityDbContext.Create().Database.Initialize(true);
        }
    }
}
