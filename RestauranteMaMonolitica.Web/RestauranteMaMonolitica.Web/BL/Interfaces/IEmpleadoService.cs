using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.Data.Models.Empleado;

namespace RestauranteMaMonolitica.Web.BL.Interfaces
{
    public interface IEmpleadoService
    {
        ServiceResult GetEmpleado(int empleadoId);
        ServiceResult GetEmpleados();
        ServiceResult UpdateEmpleados(EmpleadoUpdateModel empleadoUpdate);
        ServiceResult RemoveEmpleados(EmpleadoRemoveModel empleadoRemove);
        ServiceResult SaveEmpleados(EmpleadoSaveModel empleadoSave);
    }
}
