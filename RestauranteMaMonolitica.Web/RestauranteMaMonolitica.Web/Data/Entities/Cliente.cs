using RestauranteMaMonolitica.Web.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace RestauranteMaMonolitica.Web.Data.Entities
{
    public class Cliente : BaseEntity
    {

        [Key]
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set;}

        public string Email { get; set; }

    }
}
