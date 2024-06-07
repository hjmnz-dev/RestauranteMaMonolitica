using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;
using RestauranteMaMonolitica.Web.Data.Exceptions;

namespace RestauranteMaMonolitica.Web.Data.Repositories
{
    public class EmpleadoRepositories : IEmpleadoDb
    {
        private readonly RestauranteContext context;

        public EmpleadoRepositories(RestauranteContext context)
        {
            this.context = context;
        }

        public void SaveEmpleado(EmpleadoSaveModel empleadoSaveModel)
        {
            Empleado empleado = new Empleado()
            {
                IdEmpleado = empleadoSaveModel.IdEmpleado,
                Nombre = empleadoSaveModel.Nombre,
                Cargo = empleadoSaveModel.Cargo,
                CreationUser = empleadoSaveModel.CreationUser
            };

            this.context.Empleado.Add(empleado);
            this.context.SaveChanges();
        }

        public void RemoveEmpleado(EmpleadoRemoveModel empleadoRemoveModel)
        {
            Empleado empleadoRemove = this.context.Empleado.Find(empleadoRemoveModel.IdEmpleado);
            {
                if (empleadoRemove is null) 
                {
                    throw new EmpleadoDbException("Error a la hora de borrar empleado");
                }
                else
                {
                    empleadoRemove.Deleted = empleadoRemoveModel.Deleted;
                    empleadoRemove.DeleteDate = empleadoRemoveModel.DeleteDate;
                    empleadoRemove.DeleteUser = empleadoRemoveModel.DeleteUser;

                    this.context.Empleado.Update(empleadoRemove);
                    this.context.SaveChanges();
                }

            }
        }



        public void UpdateEmpleado(EmpleadoUpdateModel empleadoUpdateModel)
        {
            if (empleadoUpdateModel is null)
            {
                throw new EmpleadoDbException("Hubo un error al actualizar el empleado");
            }
            else
            {
                Empleado empleadoUpdate = this.context.Empleado.Find(empleadoUpdateModel.IdEmpleado);
                empleadoUpdate.ModifyDate = empleadoUpdateModel.ModifyDate;
                empleadoUpdate.UserMod = empleadoUpdateModel.UserMod;
                empleadoUpdate.Nombre = empleadoUpdateModel.Nombre;
                empleadoUpdate.Cargo = empleadoUpdateModel.Cargo;

                this.context.Update(empleadoUpdate);
                this.context.SaveChanges();
            }
        }

        public async Task<EmpleadoModel> GetEmpleado(int IdEmpleado)
        {
            var empleado = await this.context.Empleado.FindAsync(IdEmpleado);

            if (empleado == null)
            {
                throw new EmpleadoDbException("Empleado no encontrado");
            }
            else
            {
                return new EmpleadoModel()
                {
                    IdEmpleado = empleado.IdEmpleado,
                    Nombre = empleado.Nombre,
                    Cargo = empleado.Cargo
                    ,
                };
            }

        }

        public List<EmpleadoModel> GetEmpleados()
        {
            return this.context.Empleado.Select(empleados => new EmpleadoModel()
            {
                IdEmpleado = empleados.IdEmpleado,
                Nombre = empleados.Nombre,
                Cargo = empleados.Cargo
            }).ToList();
        }
    }
}
