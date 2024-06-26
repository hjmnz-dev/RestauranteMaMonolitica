using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using System.CodeDom;

namespace RestauranteMaMonolitica.Web.BL.Services
{
    public class ClienteService : IClienteService
    {

        private readonly IClienteDb clienteDb;

        public ClienteService(IClienteDb clienteDb)
        {
            this.clienteDb = clienteDb;
        }

        public ServiceResult GetCliente(int clienteId)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = clienteDb.GetCliente(clienteId);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo el cliente";

            }
            return result;
        }

        public ServiceResult GetClientes()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = clienteDb.GetClientes();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los clientes";

            }
            return result;
        }

        public ServiceResult RemoveClientes(ClienteRemoveModel clienteRemove)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = clienteDb.GetCliente(clienteId);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error eliminando los datos";

            }
            return result;
        }

        public ServiceResult SaveClientes(ClienteSaveModel clienteSave)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = clienteDb.GetCliente(clienteId);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error removiendo los datos";

            }
            return result;
        }

        public ServiceResult UpdateClientes(ClienteUpdateModel clienteUpdate)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = clienteDb.GetCliente(clienteId);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error actualizando los datos";

            }
            return result;
        }
    }
}
