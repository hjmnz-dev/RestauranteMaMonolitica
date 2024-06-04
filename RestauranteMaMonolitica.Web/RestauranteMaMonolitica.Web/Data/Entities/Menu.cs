using RestauranteMaMonolitica.Web.Data.Core;

namespace RestauranteMaMonolitica.Web.Data.Entities
{
    public class Menu: BaseEntity
    {
        public int? IdPlato { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public string Categoria { get; set; }

    }
}
