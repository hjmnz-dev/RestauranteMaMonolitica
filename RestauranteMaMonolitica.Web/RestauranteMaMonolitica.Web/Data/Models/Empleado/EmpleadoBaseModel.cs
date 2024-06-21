using System.ComponentModel.DataAnnotations;

namespace RestauranteMaMonolitica.Web.Data.Models.Empleado
{
    public abstract class EmpleadoBaseModel
    {

        [Key]
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
    }
}
