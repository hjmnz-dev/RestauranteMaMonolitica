using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models.Cliente
{
    public class ClienteUpdateModel : ClienteBaseModel
    {
        public int modify_user { get; set; }
        public DateTime modify_date { get; set; }
    }
}
