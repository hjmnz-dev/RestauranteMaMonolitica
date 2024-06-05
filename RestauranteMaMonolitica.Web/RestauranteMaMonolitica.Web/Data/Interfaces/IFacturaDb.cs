using RestauranteMaMonolitica.Web.Data.DbObjects;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IFacturaDb
    {

        void saveFactura(FacturaSaveModel facturaSave);

        void updateFactura(FacturaUpdateModel facturaUpdate);

        void removeFactura(FacturaRemoveModel facturaRemove);

     

        List<FacturaModel> GetFacturas();

        FacturaModel GetFactura(int idFactura);
        
    }
}
