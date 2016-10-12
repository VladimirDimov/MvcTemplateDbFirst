namespace TourPoc.Web.Filters
{
    using System;
    using System.Web.Mvc;
    using Services.Data.Contracts;

    public class ExceptionsHandlerFilter : IExceptionFilter
    {
        private IExceptionsService exceptionsService;

        public ExceptionsHandlerFilter(IExceptionsService exceptionsService)
        {
            this.exceptionsService = exceptionsService;
        }

        public void OnException(ExceptionContext filterContext)
        {
#if !DEBUG
            var exception = filterContext.Exception;
            this.exceptionsService.Log(filterContext.Exception.Message, filterContext.Controller.GetType().Name, exception.StackTrace, DateTime.Now);
            filterContext.Controller.ControllerContext.HttpContext.Response.Redirect($"/errors/Error500");
#endif
        }
    }
}
