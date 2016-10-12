namespace TourPoc.Services.Data.Common
{
    using System.Linq;
    using TourPoc.Data.Common;

    public class BaseService<T, TKey> : IBaseService<T, TKey>
    {
        private IDbRepository<T, TKey> repository;

        public BaseService(IDbRepository<T, TKey> repository)
        {
            this.repository = repository;
        }

        public void Add(T entity)
        {
            this.repository.Add(entity);
        }

        public IQueryable<T> All()
        {
            var all = this.repository.All();

            return all;
        }

        public T GetById(TKey id)
        {
            var entity = this.repository.GetById(id);

            return entity;
        }

        public void HardDelete(T entity)
        {
            this.repository.HardDelete(entity);
        }

        public void Save()
        {
            this.repository.Save();
        }
    }
}
