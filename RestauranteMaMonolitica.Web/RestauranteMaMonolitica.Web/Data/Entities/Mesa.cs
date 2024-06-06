using RestauranteMaMonolitica.Web.Data.Core;

namespace RestauranteMaMonolitica.Web.Data.Entities
{
    public class Mesa: BaseEntity
    {
        internal int UserDelete;

        public int MesaId { get; set; }

        public int? Capacidad { get; set; }
        
        public string? Estado { get; set; }

        


    }
}
