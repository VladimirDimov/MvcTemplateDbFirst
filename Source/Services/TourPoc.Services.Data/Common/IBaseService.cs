namespace TourPoc.Services.Data.Common
{
    using System.Linq;

    public interface IBaseService<T> : IBaseService<T, int>
    {
    }

    public interface IBaseService<T, TKey>
    {
        IQueryable<T> All();

        T GetById(TKey id);

        void Add(T entity);

        void HardDelete(T entity);

        void Save();
    }
}
