using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.BL.IValidations;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;

namespace RestauranteMaMonolitica.Web.BL.Validations
{
    public class ClienteValidation : IClienteValidation
    {
        public void ClienteGetCliente()
        {
            var cliente = new ClienteGetModel();
            ServiceResult result = new ServiceResult();
            if (cliente.IdCliente.Equals(null))
            {
                result.Success = false;
                result.Message = "Id inexistente.";

            }

            if (cliente.Nombre.Length>50)
            {
                result.Success = false;
                result.Message = "El nombre sobrepasa las 50 caracteres. ";
            }

            if (cliente.Telefono.Length > 20)
            {
                result.Success = false;
                result.Message = "El telefono sobrepasa los 20 caracteres. ";
            }

            if (cliente.Email.Length > 50)
            {
                result.Success = false;
                result.Message = "El correo sobrepasa los 50 caracteres. ";
            }
        }

        public void ClienteGetValidations(int id)
        {
            var cliente = new ClienteGetModel();
            ServiceResult result = new ServiceResult();
            if (cliente.IdCliente.Equals(null))
            {
                result.Success = false;
                result.Message = "Id de cliente invalido/inexistente.";

            }

            if (cliente.Nombre.Length > 50)
            {
                result.Success = false;
                result.Message = "El nombre sobrepasa las 50 caracteres. ";
            }

            if (cliente.Telefono.Length > 20)
            {
                result.Success = false;
                result.Message = "El telefono sobrepasa los 20 caracteres. ";
            }

            if (cliente.Email.Length > 50)
            {
                result.Success = false;
                result.Message = "El correo sobrepasa los 50 caracteres. ";
            }
        }

        public void ClienteSaveValidation(ClienteSaveModel clienteSave)
        {
            ServiceResult result = new ServiceResult();
            if (clienteSave.IdCliente.Equals(null))
            {
                result.Success = false;
                result.Message = "Id inexistente.";

            }

            if (clienteSave.Nombre.Length > 50)
            {
                result.Success = false;
                result.Message = "El nombre sobrepasa las 50 caracteres. ";
            }

            if (clienteSave.Telefono.Length > 20)
            {
                result.Success = false;
                result.Message = "El telefono sobrepasa los 20 caracteres. ";
            }

            if (clienteSave.Email.Length > 50)
            {
                result.Success = false;
                result.Message = "El correo sobrepasa los 50 caracteres. ";
            }
        }

        public void ClienteUpdateValidation(ClienteUpdateModel clienteUpdate)
        {
            ServiceResult result = new ServiceResult();
            if (clienteUpdate.IdCliente.Equals(null))
            {
                result.Success = false;
                result.Message = "Id inexistente.";

            }

            if (clienteUpdate.Nombre.Length > 50)
            {
                result.Success = false;
                result.Message = "El nombre sobrepasa las 50 caracteres. ";
            }

            if (clienteUpdate.Telefono.Length > 20)
            {
                result.Success = false;
                result.Message = "El telefono sobrepasa los 20 caracteres. ";
            }

            if (clienteUpdate.Email.Length > 50)
            {
                result.Success = false;
                result.Message = "El correo sobrepasa los 50 caracteres. ";
            }
        }
    }
}
