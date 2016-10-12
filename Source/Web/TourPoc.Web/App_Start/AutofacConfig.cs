namespace TourPoc.Web
{
    using System.Data.Entity;
    using System.Reflection;
    using System.Web.Mvc;

    using Autofac;
    using Autofac.Integration.Mvc;

    using Controllers;

    using Data;
    using Data.Common;
    using IO.Swagger.Api;
    using Libraries.Providers;
    using Services.Data.Common;
    using Services.Data.Contracts;
    using Services.Web;

    public static class AutofacConfig
    {
        public static void RegisterAutofac()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // Register services
            RegisterCommon(builder);
            RegisterServices(builder);
            RegisterLibraries(builder);
            RegisterDatabase(builder);
            RegisterFilters(builder);

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void RegisterFilters(ContainerBuilder builder)
        {
        }

        private static void RegisterCommon(ContainerBuilder builder)
        {
            builder.Register(x => new HttpCacheService())
                .As<ICacheService>()
                .InstancePerRequest();

            builder.Register(x => new IdentifierProvider())
                .As<IIdentifierProvider>()
                .InstancePerRequest();

            var swaggerAssembly = Assembly.GetAssembly(typeof(DefaultApi));
            builder.RegisterAssemblyTypes(swaggerAssembly).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AssignableTo<BaseController>().PropertiesAutowired();
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            var servicesContractsAssembly = Assembly.GetAssembly(typeof(IFlightServices));
            builder.RegisterAssemblyTypes(servicesContractsAssembly).AsImplementedInterfaces();

            var servicesCommonAssembly = Assembly.GetAssembly(typeof(IBaseService<>));
            builder.RegisterAssemblyTypes(servicesCommonAssembly).AsImplementedInterfaces();
        }

        private static void RegisterLibraries(ContainerBuilder builder)
        {
            var providersAssembly = Assembly.GetAssembly(typeof(FlightsProvider));
            builder.RegisterAssemblyTypes(providersAssembly).AsImplementedInterfaces();
        }

        private static void RegisterDatabase(ContainerBuilder builder)
        {
            builder.Register(x => new ApplicationDbContext())
                .As<DbContext>()
                .InstancePerRequest();

            builder.RegisterGeneric(typeof(DbRepository<>))
                .As(typeof(IDbRepository<>))
                .InstancePerRequest();

            builder.RegisterGeneric(typeof(DbRepository<,>))
                .As(typeof(IDbRepository<,>))
                .InstancePerRequest();
        }
    }
}
