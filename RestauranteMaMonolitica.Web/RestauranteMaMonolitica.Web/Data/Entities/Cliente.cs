using RestauranteMaMonolitica.Web.Data.Core;

namespace RestauranteMaMonolitica.Web.Data.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set;}

        public string Email { get; set; }

    }
}
