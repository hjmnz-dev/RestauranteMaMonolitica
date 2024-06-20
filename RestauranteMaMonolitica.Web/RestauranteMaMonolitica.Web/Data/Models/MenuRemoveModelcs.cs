using RestauranteMaMonolitica.Web.Data.Core;
using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models
{
    public class MenuRemoveModelcs: MenuModelBase
    {
        public int deleted_user{ get; set; }
        public DateTime? deleted_date { get; set; }

        public bool? deleted { get; set; }
    }

    
}
