using RestauranteMaMonolitica.Web.Data.DbObjects;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IFacturaDb
    {

        void save(Factura factura);
    }
}
