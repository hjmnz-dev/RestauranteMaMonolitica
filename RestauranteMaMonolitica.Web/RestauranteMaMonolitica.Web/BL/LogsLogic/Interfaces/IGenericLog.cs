namespace RestauranteMaMonolitica.Web.BL.LogsLogic.Interfaces
{
    public interface IGenericLog
    {
        void LogInformation(string message);
        void LogError(string message, Exception exception);
    }
}
