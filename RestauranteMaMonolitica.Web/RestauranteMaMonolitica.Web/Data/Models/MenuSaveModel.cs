using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models
{
    public class MenuSaveModel :MenuModelBase
    {

        public DateTime? modify_date { get; set; }
        public int creation_user { get; set; }
    }
}
