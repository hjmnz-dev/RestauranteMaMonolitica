using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;
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

        public List<ClienteModel> GetClientes()
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
        public async Task<ClienteModel> GetCliente(int idCliente)
        {
            return await _clienteRepositories.GetCliente(idCliente);
        }
    }
}