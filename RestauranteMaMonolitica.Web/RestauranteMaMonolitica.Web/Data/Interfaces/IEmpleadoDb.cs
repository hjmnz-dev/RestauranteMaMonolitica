using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IEmpleadoDb
    {
        void Save(Empleado empleado);
    }
}
