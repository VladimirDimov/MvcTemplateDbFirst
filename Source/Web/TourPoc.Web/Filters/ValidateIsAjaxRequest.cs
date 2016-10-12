namespace TourPoc.Web.Filters
{
    using System;
    using System.Web.Mvc;

    /// <summary>
    /// If the request is not ana AJAX an error is thrown.
    /// </summary>
    public class ValidateIsAjaxRequest : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.HttpContext.Request.IsAjaxRequest())
            {
                throw new NotAjaxRequestException("Invalid not an AJAX request!");
            }

            base.OnActionExecuting(filterContext);
        }

        public class NotAjaxRequestException : Exception
        {
            public NotAjaxRequestException()
            {
            }

            public NotAjaxRequestException(string message)
                : base(message)
            {
            }
        }
    }
}
