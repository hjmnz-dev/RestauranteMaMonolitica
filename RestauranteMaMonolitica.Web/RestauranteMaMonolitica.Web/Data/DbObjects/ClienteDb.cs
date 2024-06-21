using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using RestauranteMaMonolitica.Web.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestauranteMaMonolitica.Web.Data.DbObjects
{
    public class ClienteDb : IClienteDb
    {
        private readonly ClienteRepositories _clienteRepositories;

        public ClienteDb(ClienteRepositories clienteRepositories)
        {
            _clienteRepositories = clienteRepositories;
        }

        public List<ClienteGetModel> GetClientes()
        {
            return _clienteRepositories.GetClientes();
        }

        public void SaveCliente(ClienteSaveModel clienteSaveModel)
        {
            _clienteRepositories.SaveCliente(clienteSaveModel);
        }

        public void RemoveCliente(ClienteRemoveModel clienteRemoveModel)
        {
            _clienteRepositories.RemoveCliente(clienteRemoveModel);
        }

        public void UpdateCliente(ClienteUpdateModel clienteUpdateModel)
        {
            _clienteRepositories.UpdateCliente(clienteUpdateModel);
        }
        public ClienteGetModel GetCliente(int idCliente)
        {
            return _clienteRepositories.GetCliente(idCliente);
        }
    }
}