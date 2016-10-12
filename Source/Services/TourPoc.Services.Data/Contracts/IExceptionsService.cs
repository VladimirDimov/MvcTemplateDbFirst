namespace TourPoc.Services.Data.Contracts
{
    using System;

    public interface IExceptionsService
    {
        void Log(string message, string controllerName, string stackTrace, DateTime logDateTime);
    }
}
