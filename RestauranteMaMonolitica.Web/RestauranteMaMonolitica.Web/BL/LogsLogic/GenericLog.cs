using RestauranteMaMonolitica.Web.BL.LogsLogic.Interfaces;

namespace RestauranteMaMonolitica.Web.BL.LogsLogic
{
    public class GenericLog<T> : IGenericLog
    {
        private readonly ILogger<T> _logger;

        public GenericLog(ILogger<T> logger)
        {
            _logger = logger;
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }

        public void LogError(string message, Exception exception)
        {
            _logger.LogError(exception, message);
        }
    }
}
