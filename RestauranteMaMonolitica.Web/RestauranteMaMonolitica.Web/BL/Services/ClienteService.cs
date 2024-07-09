using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.BL.Exceptions;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.BL.LogsLogic.Interfaces;
using RestauranteMaMonolitica.Web.BL.Validations;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using System.CodeDom;

namespace RestauranteMaMonolitica.Web.BL.Services
{
    public class ClienteService : IClienteService
    {

        private readonly IClienteDb clienteDb;
        private  readonly ClienteValidation clienteValidation;
        private readonly IGenericLog logger;

        public ClienteService(IClienteDb clienteDb, IGenericLog logger)
        {
            this.clienteDb = clienteDb;
            this.logger = logger;
        }

        public ServiceResult GetClientes()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                clienteValidation.ClienteGetCliente();
                result.Data = clienteDb.GetClientes();

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Hubo un error al obtener los clientes";
                this.logger.LogError(result.Message, ex.InnerException);
                this.logger.LogInformation(result.Message);
            }
            return result;
        }

        public ServiceResult GetCliente(int clienteId)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                clienteValidation.ClienteGetValidations(clienteId);
                result.Data = clienteDb.GetCliente(clienteId);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Hubo un error al obtener el cliente";
                this.logger.LogError(result.Message, ex.InnerException);
                this.logger.LogInformation(result.Message);
            }
            return result;
        }

        

        public ServiceResult RemoveClientes(ClienteRemoveModel clienteRemove)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                this.clienteDb.RemoveCliente(clienteRemove);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se pudo eliminar el cliente";
            }
            return result;
        }

        public ServiceResult SaveClientes(ClienteSaveModel clienteSave)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                clienteValidation.ClienteSaveValidation(clienteSave);
                this.clienteDb.SaveCliente(clienteSave);

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se pudo crear el cliente";
                this.logger.LogError(result.Message, ex.InnerException);
                this.logger.LogInformation(result.Message);
            }
            return result;
        }

        public ServiceResult UpdateClientes(ClienteUpdateModel clienteUpdate)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                clienteDb.UpdateCliente(clienteUpdate);
                this.clienteDb.UpdateCliente(clienteUpdate);
            }

            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se pudo actualizar el cliente";
                this.logger.LogError(result.Message, ex.InnerException);
                this.logger.LogInformation(result.Message);
            }
            return result;
        }
    }
}
