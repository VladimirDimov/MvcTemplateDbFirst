namespace TourPoc.Web
{
    using System.Web.Mvc;
    using Filters;
    using Services.Data.Contracts;

    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters, IExceptionsService exceptionService)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ExceptionsHandlerFilter(exceptionService));
        }
    }
}
