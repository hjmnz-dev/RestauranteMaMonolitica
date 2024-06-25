namespace RestauranteMaMonolitica.Web.BL.Core
{
    public class FacturaServiceResult
    {

        public FacturaServiceResult() 
        {
            this.Sucess = true;
        }
        public bool Sucess {  get; set; }
        public string? Message { get; set; }
        public dynamic? Data { get; set; }


    }
}
