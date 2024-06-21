using System.ComponentModel.DataAnnotations;

namespace RestauranteMaMonolitica.Web.Data.Models.Cliente
{
    public abstract class ClienteBaseModel
    {

        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
