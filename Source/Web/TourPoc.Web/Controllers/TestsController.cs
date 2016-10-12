namespace TourPoc.Web.Controllers
{
    using System.Web.Mvc;
    using Services.Data.Contracts;

    public class TestsController : BaseController
    {
        private ITestServices testsService;

        public TestsController(ITestServices testsService)
        {
            this.testsService = testsService;
        }

        public ActionResult Index()
        {
            var tests = this.testsService.All();

            return this.View(tests);
        }
    }
}
