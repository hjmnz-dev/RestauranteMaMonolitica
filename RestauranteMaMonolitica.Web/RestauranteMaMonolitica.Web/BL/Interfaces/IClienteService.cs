using RestauranteMaMonolitica.Web.Data.Models.Cliente;

namespace RestauranteMaMonolitica.Web.BL.Core
{
    public interface IClienteService
    {
        ServiceResult GetCliente(int clienteId);
        ServiceResult GetClientes();
        ServiceResult UpdateClientes(ClienteUpdateModel clienteUpdate);
        ServiceResult RemoveClientes(ClienteRemoveModel clienteRemove);
        ServiceResult SaveClientes(ClienteSaveModel clienteSave);
    }
}
