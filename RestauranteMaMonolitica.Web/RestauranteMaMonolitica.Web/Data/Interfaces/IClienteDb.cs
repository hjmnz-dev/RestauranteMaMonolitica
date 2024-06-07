using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IClienteDb
    {
        void SaveCliente(ClienteSaveModel cliente);
        void UpdateCliente(ClienteUpdateModel cliente);
        void RemoveCliente(ClienteRemoveModel cliente);
        List<ClienteModel> GetClientes();
        Task<ClienteModel> GetCliente(int IdCliente);
        

    }
}
