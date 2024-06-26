using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models.Empleado
{
    public class EmpleadoUpdateModel : EmpleadoBaseModel
    {
        public int modify_user { get; set; }
        public DateTime modify_date { get; set; }

      
    }
}
