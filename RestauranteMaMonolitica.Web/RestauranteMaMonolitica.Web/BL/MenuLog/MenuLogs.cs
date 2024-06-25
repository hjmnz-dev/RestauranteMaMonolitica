using RestauranteMaMonolitica.Web.BL.MenuLog.Interfaces;

namespace RestauranteMaMonolitica.Web.BL.MenuLog
{
    public class MenuLogs<T> : IMenuLogs
    {
        private readonly ILogger<T> _logger;

        public MenuLogs(ILogger<T> logger)
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

