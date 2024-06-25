namespace RestauranteMaMonolitica.Web.BL.Core
{
    public class ServiceResult
    {
        public ServiceResult()
        {
            this.success = true;
        }
        public bool success { get; set; }
        public string? Messge { get; set; }

        public dynamic? Data { get; set; }

    }
}
