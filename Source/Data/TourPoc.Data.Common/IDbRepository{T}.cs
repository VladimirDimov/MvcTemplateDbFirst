namespace TourPoc.Data.Common
{
    using System.Linq;

    using TourPoc.Data.Common.Models;

    public interface IDbRepository<T> : IDbRepository<T, int>
    {
    }

    public interface IDbRepository<T, in TKey>
    {
        IQueryable<T> All();

        T GetById(TKey id);

        void Add(T entity);

        void HardDelete(T entity);

        void Save();
    }
}
