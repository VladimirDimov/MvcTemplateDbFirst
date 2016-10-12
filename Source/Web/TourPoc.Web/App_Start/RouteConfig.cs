namespace TourPoc.Web
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Flights", action = "Search", id = UrlParameter.Optional },
                namespaces: new string[] { "TourPoc.Web.Controllers" });
        }
    }
}
