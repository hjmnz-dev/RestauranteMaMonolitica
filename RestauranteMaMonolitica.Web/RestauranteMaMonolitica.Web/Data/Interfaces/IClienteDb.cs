using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IClienteDb
    {
        void Save(Cliente cliente);
    }
}
