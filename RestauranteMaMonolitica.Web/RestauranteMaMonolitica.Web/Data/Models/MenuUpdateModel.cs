using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models
{
    public class MenuUpdateModel: MenuModelBase
    {
        public DateTime? ModifyDate { get; set; }
        public int? CreationUser { get; set; }
        public int ModifyUser { get; set; }

    }
}
