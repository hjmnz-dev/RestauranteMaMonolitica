using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.BL.IValidations;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using RestauranteMaMonolitica.Web.Data.Models.Empleado;

namespace RestauranteMaMonolitica.Web.BL.Validations
{
    public class EmpleadoValidation : IEmpleadoValidation
    {
        public void EmpleadoGetValidations(int id)
        {
            var empleado = new EmpleadoGetModel();
            ServiceResult result = new ServiceResult();
            if (empleado.IdEmpleado.Equals(null))
            {
                result.Success = false;
                result.Message = "Id de empleado invalido/inexistente.";

            }

            if (empleado.Nombre.Length > 50)
            {
                result.Success = false;
                result.Message = "El nombre sobrepasa las 50 caracteres. ";
            }

            if (empleado.Cargo.Length > 50)
            {
                result.Success = false;
                result.Message = "El cargo sobrepasa los 50 caracteres. ";
            }

        }

        public void EmpleadoGetEmpleado()
        {
            var empleado = new EmpleadoGetModel();
            ServiceResult result = new ServiceResult();
            if (empleado.IdEmpleado.Equals(null))
            {
                result.Success = false;
                result.Message = "Id de empleado invalido/inexistente.";

            }

            if (empleado.Nombre.Length > 50)
            {
                result.Success = false;
                result.Message = "El nombre sobrepasa las 50 caracteres. ";
            }

            if (empleado.Cargo.Length > 50)
            {
                result.Success = false;
                result.Message = "El cargo sobrepasa los 50 caracteres. ";
            }
        }

        public void EmpleadoSaveValidation(EmpleadoSaveModel empleadoSave)
        {
            ServiceResult result = new ServiceResult();
            if (empleadoSave.IdEmpleado.Equals(null))
            {
                result.Success = false;
                result.Message = "Id de empleado invalido/inexistente.";

            }

            if (empleadoSave.Nombre.Length > 50)
            {
                result.Success = false;
                result.Message = "El nombre sobrepasa las 50 caracteres. ";
            }

            if (empleadoSave.Cargo.Length > 50)
            {
                result.Success = false;
                result.Message = "El cargo sobrepasa los 50 caracteres. ";
            }
        }

        public void EmpleadoUpdateValidation(EmpleadoUpdateModel empleadoUpdate)
        {
            ServiceResult result = new ServiceResult();
            if (empleadoUpdate.IdEmpleado.Equals(null))
            {
                result.Success = false;
                result.Message = "Id de empleado invalido/inexistente.";

            }

            if (empleadoUpdate.Nombre.Length > 50)
            {
                result.Success = false;
                result.Message = "El nombre sobrepasa las 50 caracteres. ";
            }

            if (empleadoUpdate.Cargo.Length > 50)
            {
                result.Success = false;
                result.Message = "El cargo sobrepasa los 50 caracteres. ";
            }
        }
    }
}
