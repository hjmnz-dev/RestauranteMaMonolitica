using RestauranteMaMonolitica.Web.Data.Core;

namespace RestauranteMaMonolitica.Web.Data.Entities
{
    public class Factura : BaseEntity
    {

        public int idFactura { get; set; }

        public int idPedido { get; set; }

        public decimal Total { get; set; }
        public DateTime Fecha{ get; set; }

        





     }
}
