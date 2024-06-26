using RestauranteMaMonolitica.Web.Data.Models.Cliente;

namespace RestauranteMaMonolitica.Web.BL.Core
{
    public interface IClienteService
    {
        ServiceResult GetClientes();

        ServiceResult GetCliente(int  clienteId);

        ServiceResult UpdateClientes(ClienteUpdateModel clienteUpdate);

        ServiceResult RemoveClientes(ClienteRemoveModel clienteRemove);

        ServiceResult SaveClientes(ClienteSaveModel clienteSave);
    }
}
