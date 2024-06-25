using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.BL.Interfaces
{
    public interface IFacturaService
    {
        FacturaServiceResult GetFacturas();

        FacturaServiceResult GetFactura(int id);

        FacturaServiceResult updateFactura(FacturaUpdateModel facturaUpdate);

        FacturaServiceResult removeFactura(FacturaRemoveModel facturaRemove);

        FacturaServiceResult saveFactura(FacturaSaveModel facturaSave);


    }
}
