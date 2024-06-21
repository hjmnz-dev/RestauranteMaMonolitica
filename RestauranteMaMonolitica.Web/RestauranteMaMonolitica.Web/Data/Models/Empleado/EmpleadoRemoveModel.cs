using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models.Empleado
{
    public class EmpleadoRemoveModel : EmpleadoBaseModel
    {
        public int delete_user { get; set; }
        public DateTime delete_date { get; set; }
        public bool deleted { get; set; }

        protected EmpleadoRemoveModel()
        {
            this.deleted = false;
        }
       

    }
}
