using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models.Cliente
{
    public class ClienteRemoveModel : ClienteBaseModel
    {
        public int delete_user { get; set; }
        public DateTime delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
