using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Models.Cliente
{
    public class ClienteSaveModel : ClienteBaseModel
    {
        public int creation_user { get; set; }
        public DateTime creation_date { get; set; }

    }
}
