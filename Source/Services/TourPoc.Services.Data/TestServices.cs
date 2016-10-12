namespace TourPoc.Services.Data
{
    using Common;
    using Contracts;
    using TourPoc.Data;
    using TourPoc.Data.Common;

    public class TestServices : BaseService<Test>, ITestServices
    {
        public TestServices(IDbRepository<Test> testsRepo)
            : base(testsRepo)
        {
        }
    }
}
