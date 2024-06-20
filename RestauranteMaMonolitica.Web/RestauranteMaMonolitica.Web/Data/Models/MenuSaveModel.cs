using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models
{
    public class MenuSaveModel :MenuModelBase
    {
        public int creation_user { get; set; }
        public DateTime creation_date { get; set; }
    }
}
