using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IDetallePedidoDb
    {
        void save(DetallePedido detallePedido);
        void delete(DetallePedido detallePedido);   
        
    }
}
