using RestauranteMaMonolitica.Web.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace RestauranteMaMonolitica.Web.Data.Entities
{
    public class Factura : BaseEntity
    {

        [Key]
        public int IdFactura { get; set; }

        public int? IdPedido { get; set; }

        public decimal Total { get; set; }
        public DateTime Fecha{ get; set; }

        





     }
}
