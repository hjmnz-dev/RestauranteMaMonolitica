using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IEmpleadoDb
    {
        void SaveEmpleado(EmpleadoSaveModel empleadoSaveModel);
        void UpdateEmpleado(EmpleadoUpdateModel empleadoUpdateModel);
        void RemoveEmpleado(EmpleadoRemoveModel empleadoRemoveModel);
        List<EmpleadoModel> GetEmpleados();
        Task<EmpleadoModel> GetEmpleado(int IdEmpleado);
    }
}
