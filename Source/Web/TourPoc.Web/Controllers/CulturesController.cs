namespace TourPoc.Web.Controllers
{
    using System.Web.Mvc;

    public class CulturesController : BaseController
    {
        public ActionResult ChangeLanguage(string language)
        {
            this.Response.Cookies.Add(new System.Web.HttpCookie("Language", language));

            return this.RedirectToAction("Index", "Home");
        }
    }
}
