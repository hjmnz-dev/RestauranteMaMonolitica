namespace RestauranteMaMonolitica.Web.Data.Core
{
    public abstract class FacturaBaseEntity : BaseEntity
    {

        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }






    }
}
