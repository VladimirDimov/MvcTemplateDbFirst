namespace TourPoc.Web.Controllers
{
    using System;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return this.View("index");
        }
    }
}
