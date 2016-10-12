namespace TourPoc.Services.Data.Common
{
    using TourPoc.Data.Common;

    public class BaseService<T> : BaseService<T, int>
    {
        public BaseService(IDbRepository<T, int> repository)
            : base(repository)
        {
        }
    }
}
