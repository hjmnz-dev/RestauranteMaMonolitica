using RestauranteMaMonolitica.Web.Data.DbObjects;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IFacturaDb
    {

        void saveFactura(FacturaSaveModel factura);

        void updateFactura(FacturaUpdateModel facturaUpdate);

        void removeFactura(FacturaRemoveModel facturaRemove);

     

        List<FacturaGetModel> GetFacturas();

        FacturaGetModel GetFactura(int IdFactura);
        
    }
}
