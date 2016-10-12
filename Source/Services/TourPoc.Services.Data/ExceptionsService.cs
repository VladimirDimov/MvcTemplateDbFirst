namespace TourPoc.Services.Data
{
    using System;
    using Contracts;
    using TourPoc.Data;
    using TourPoc.Data.Common;

    public class ExceptionsService : IExceptionsService
    {
        private IDbRepository<Log> logsRepository;

        public ExceptionsService(IDbRepository<Log> logsRepository)
        {
            this.logsRepository = logsRepository;
        }

        public void Log(string message, string controllerName, string stackTrace, DateTime logDateTime)
        {
            this.logsRepository.Add(new Log
            {
                ExceptionMessage = message,
                ControllerName = controllerName,
                ExceptionStackTrace = stackTrace,
                LogTime = logDateTime
            });

            this.logsRepository.Save();
        }
    }
}
