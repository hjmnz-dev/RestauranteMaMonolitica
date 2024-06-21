using RestauranteMaMonolitica.Web.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace RestauranteMaMonolitica.Web.Data.Entities
{
    public class Empleado : BaseEntity
    {

        [Key]
        public int IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

    }
}
