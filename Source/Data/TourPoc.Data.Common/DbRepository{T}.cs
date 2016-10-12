namespace TourPoc.Data.Common
{
    using System.Data.Entity;

    public class DbRepository<T> : DbRepository<T, int>, IDbRepository<T>
    where T : class
    {
        public DbRepository(DbContext context)
            : base(context)
        {
        }
    }
}
