using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models.Empleado
{
    public class EmpleadoSaveModel : EmpleadoBaseModel
    {

        public int creation_user { get; set; }
        public DateTime creation_date { get; set; }

        
        
    }
}
