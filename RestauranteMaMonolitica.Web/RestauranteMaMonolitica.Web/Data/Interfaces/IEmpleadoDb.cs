using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Models.Empleado;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IEmpleadoDb
    {
        void SaveEmpleado(EmpleadoSaveModel empleadoSaveModel);
        void UpdateEmpleado(EmpleadoUpdateModel empleadoUpdateModel);
        void RemoveEmpleado(EmpleadoRemoveModel empleadoRemoveModel);
        List<EmpleadoGetModel> GetEmpleados();
        EmpleadoGetModel GetEmpleado(int IdEmpleado);
    }
}
