using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.BL.Exceptions;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using System.CodeDom;

namespace RestauranteMaMonolitica.Web.BL.Services
{
    public class ClienteService : IClienteService
    {

        private readonly IClienteDb clienteDb;
        private readonly ILogger<ClienteService> logger;

        public ClienteService(IClienteDb clienteDb, ILogger<ClienteService> logger)
        {
            this.clienteDb = clienteDb;
            this.logger = logger;
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
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result;
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

        

        public ServiceResult RemoveClientes(ClienteRemoveModel clienteRemove)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if(clienteRemove is null) {
                    result.Success = false;
                    result.Message = "El cliente no puede ser nulo.";
                    return result;
                }
                this.clienteDb.RemoveCliente(clienteRemove);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error removiendo los datos";

            }
            return result;
        }

        public ServiceResult SaveClientes(ClienteSaveModel clienteSave)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (clienteSave is null)
                {
                    result.Success = false;
                    result.Message = "El cliente no puede ser nulo.";
                    return result;
                }
                /*
                if (clienteUpdate is null)
                    throw new ClienteServiceException("El cliente no puede ser nulo.");
                */

                if (string.IsNullOrEmpty(clienteSave.Nombre))
                {
                    result.Success = false;
                    result.Message = "El nombre del cliente es requerido.";
                    return result;
                }

                if (clienteSave.Nombre.Length > 50)
                {
                    result.Success = false;
                    result.Message = "La longitud del nombre de cliente debe ser menor a 50 caracteres.";
                    return result;
                }

                this.clienteDb.SaveCliente(clienteSave);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error actualizando los datos";

            }
            return result;
        }

        public ServiceResult UpdateClientes(ClienteUpdateModel clienteUpdate)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (clienteUpdate is null)
                {
                    result.Success=false;
                    result.Message = "El cliente no puede ser nulo.";
                    return result;
                }
                /*
                if (clienteUpdate is null)
                    throw new ClienteServiceException("El cliente no puede ser nulo.");
                */

                if(string.IsNullOrEmpty(clienteUpdate.Nombre))
                {
                    result.Success=false;
                    result.Message = "El nombre del cliente es requerido.";
                    return result;
                }

                if (clienteUpdate.Nombre.Length > 50)
                {
                    result.Success = false;
                    result.Message = "La longitud del nombre de cliente debe ser menor a 50 caracteres.";
                    return result;
                }

                this.clienteDb.UpdateCliente(clienteUpdate);
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
