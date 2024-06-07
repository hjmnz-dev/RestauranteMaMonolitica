using RestauranteMaMonolitica.Web.Data.Core;

namespace RestauranteMaMonolitica.Web.Data.Entities
{
    public class Empleado : BaseEntity
    {
        public int IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

    }
}
