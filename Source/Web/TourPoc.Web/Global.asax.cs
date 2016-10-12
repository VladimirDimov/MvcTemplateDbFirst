namespace TourPoc.Web
{
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using App_Start;
    using Data;
    using Data.Common;

    using Infrastructure.Mapping;
    using Multilingual;
    using Services.Data;

#pragma warning disable SA1649 // File name must match first type name

    public class MvcApplication : HttpApplication
#pragma warning restore SA1649 // File name must match first type name
    {
        protected void Application_Start()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            DatabaseConfig.Initialize();
            AutofacConfig.RegisterAutofac();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters, new ExceptionsService(new DbRepository<Log>(new ApplicationDbContext())));
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // START Register translation module
            ControllerBuilder
                            .Current
                            .SetControllerFactory(new DefaultControllerFactory(new LocalizedControllerActivator()));

            TranslateExtensionMethods.TranslationsDictionary =
                            TranslationsResourceProvider.Instance(this.Server.MapPath("~/resources/translations.json"), "en");
            // END Register translation module

            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(Assembly.GetExecutingAssembly());
        }
    }
}
