using RestauranteMaMonolitica.Web.Data.Models.Cliente;

namespace RestauranteMaMonolitica.Web.BL.IValidations
{
    public interface IClienteValidation
    {
        void ClienteUpdateValidation(ClienteUpdateModel clienteUpdate);
        void ClienteSaveValidation(ClienteSaveModel clienteSave);
        void ClienteGetCliente();
        void ClienteGetValidations(int id);
    }
}
