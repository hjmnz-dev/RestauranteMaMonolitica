using RestauranteMaMonolitica.Web.BL.Services;

namespace RestauranteMaMonolitica.Web.BL.MenuLog.Interfaces
{
    public interface IMenuLogs
    {
        void LogInformation(string message);
        void LogError(string message, Exception exception);
    }
}
