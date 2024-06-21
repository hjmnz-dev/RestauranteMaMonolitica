using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Exceptions;
using RestauranteMaMonolitica.Web.Data.Models.Empleado;

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
                creation_user = empleadoSaveModel.creation_user
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
                    empleadoRemove.deleted = empleadoRemoveModel.deleted;
                    empleadoRemove.delete_date = empleadoRemoveModel.delete_date;
                    empleadoRemove.delete_user = empleadoRemoveModel.delete_user;

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
                empleadoUpdate.modify_date = empleadoUpdateModel.modify_date;
                empleadoUpdate.modify_user = empleadoUpdateModel.modify_user;
                empleadoUpdate.Nombre = empleadoUpdateModel.Nombre;
                empleadoUpdate.Cargo = empleadoUpdateModel.Cargo;

                this.context.Update(empleadoUpdate);
                this.context.SaveChanges();
            }
        }

        public EmpleadoGetModel GetEmpleado(int IdEmpleado)
        {
            var empleado = this.context.Empleado.Find(IdEmpleado);

            if (empleado == null)
            {
                throw new EmpleadoDbException("Empleado no encontrado");
            }
            
                return new EmpleadoGetModel()
                {
                    IdEmpleado = empleado.IdEmpleado,
                    Nombre = empleado.Nombre,
                    Cargo = empleado.Cargo
                    
                };
            

        }

        public List<EmpleadoGetModel> GetEmpleados()
        {
            return this.context.Empleado.Select(empleados => new EmpleadoGetModel()
            {
                IdEmpleado = empleados.IdEmpleado,
                Nombre = empleados.Nombre,
                Cargo = empleados.Cargo
            }).ToList();
        }
    }
}
