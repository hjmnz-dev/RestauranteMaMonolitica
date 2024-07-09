using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using RestauranteMaMonolitica.Web.Data.Models.Empleado;

namespace RestauranteMaMonolitica.Web.BL.IValidations
{
    public interface IEmpleadoValidation
    {
        void EmpleadoUpdateValidation(EmpleadoUpdateModel empleadoUpdate);
        void EmpleadoSaveValidation(EmpleadoSaveModel empleadoSave);
        void EmpleadoGetEmpleado();
        void EmpleadoGetValidations(int id);
    }
}
