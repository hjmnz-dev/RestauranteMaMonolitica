using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.BL.IValidations;
using RestauranteMaMonolitica.Web.BL.LogsLogic.Interfaces;
using RestauranteMaMonolitica.Web.BL.Validations;
using RestauranteMaMonolitica.Web.Data.DbObjects;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models.Empleado;

namespace RestauranteMaMonolitica.Web.BL.Services
{
    public class EmpleadoService : IEmpleadoService
    {

        private readonly IEmpleadoDb empleadoDb;
        private readonly EmpleadoValidation empleadoValidation;
        private readonly IGenericLog logger;

        public EmpleadoService(IEmpleadoDb empleadoDb, IGenericLog logger)
        {
            this.empleadoDb = empleadoDb;
            this.logger = logger;
        }
        public ServiceResult GetEmpleado(int empleadoId)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                empleadoValidation.EmpleadoGetValidations(empleadoId);
                result.Data = empleadoDb.GetEmpleado(empleadoId);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Hubo un error al obtener el empleado";
                this.logger.LogError(result.Message, ex.InnerException);
                this.logger.LogInformation(result.Message);
            }
            return result;
        }

        public ServiceResult GetEmpleados()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                empleadoValidation.EmpleadoGetEmpleado();
                result.Data = empleadoDb.GetEmpleados();

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Hubo un error al obtener los empleados";
                this.logger.LogError(result.Message, ex.InnerException);
                this.logger.LogInformation(result.Message);
            }
            return result;
        }

        public ServiceResult RemoveEmpleados(EmpleadoRemoveModel empleadoRemove)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                this.empleadoDb.RemoveEmpleado(empleadoRemove);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se pudo eliminar el empleado";
            }
            return result;
        }

        public ServiceResult SaveEmpleados(EmpleadoSaveModel empleadoSave)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                empleadoValidation.EmpleadoSaveValidation(empleadoSave);
                this.empleadoDb.SaveEmpleado(empleadoSave);

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se pudo crear el empleado";
                this.logger.LogError(result.Message, ex.InnerException);
                this.logger.LogInformation(result.Message);
            }
            return result;
        }

        public ServiceResult UpdateEmpleados(EmpleadoUpdateModel empleadoUpdate)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                empleadoValidation.EmpleadoUpdateValidation(empleadoUpdate);
                this.empleadoDb.UpdateEmpleado(empleadoUpdate);
            }

            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se pudo actualizar el empleado";
                this.logger.LogError(result.Message, ex.InnerException);
                this.logger.LogInformation(result.Message);
            }
            return result;
        }
    }
}
