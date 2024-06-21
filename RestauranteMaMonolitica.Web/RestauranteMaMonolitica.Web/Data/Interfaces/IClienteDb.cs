using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IClienteDb
    {
        void SaveCliente(ClienteSaveModel cliente);
        void UpdateCliente(ClienteUpdateModel cliente);
        void RemoveCliente(ClienteRemoveModel cliente);
        List<ClienteGetModel> GetClientes();
        public ClienteGetModel GetCliente(int IdCliente);
        

    }
}
