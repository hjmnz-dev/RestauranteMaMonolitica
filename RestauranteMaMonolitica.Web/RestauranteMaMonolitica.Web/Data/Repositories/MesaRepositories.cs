using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Exceptions;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Data.Repositories
{
    public class MesaRepositories : IMesaRepositories
    {
        private readonly RestauranteContext context;
        public MesaRepositories(RestauranteContext context)
        {
            this.context = context;
        }

        public void Save(MesaSaveModel mesaSave)
        {
            Mesa mesa = new Mesa()
            {
                Capacidad = mesaSave.Capacidad,
                Estado = mesaSave.Estado,
                CreationDate = mesaSave.CreationDate,
                CreationUser = mesaSave.CreationUser

            };
            this.context.Mesa.Add(mesa);
            this.context.SaveChanges();

        }
        public void Update (MesaUpdateModel mesaUpdate)
        {
            if (mesaUpdate is null)
            {
                throw new MesaDbException("La Mesa tuvo un error al actualizar");

            }

            Mesa mesa = this.context.Mesa.Find(mesaUpdate.MesaId);

            mesa.ModifyDate = mesaUpdate.ModifyDate;
            mesa.UserMod = mesaUpdate.UserMod;
            mesa.Capacidad = mesaUpdate.Capacidad;
            mesa.Estado = mesaUpdate.Estado;

            this.context.Mesa.Update(mesa);
            this.context.SaveChanges();
        }

        public void Remove(MesaRemoveModel mesaRemoveModel) 
        {
           
            Mesa mesaRemove = this.context.Mesa.Find(MesaRemoveModel.MesaId);

            {
                if (mesaRemove is null)
                {
                    throw new MesaDbException(" Error al eliminar un dato: Mesa no encontrada");
                }
                else
                {

                    mesaRemove.Deleted = mesaRemoveModel.Deleted;
                    mesaRemove.DeletedDate = mesaRemoveModel.DeletedDate;
                    mesaRemove.DeletedUser = mesaRemoveModel.DeletedUser;

                    this.context.Mesa.Update(mesaRemove);
                    this.context.SaveChanges();

                }
            }
        }

        public List<MesaModel> GetMesas()
        {
            return this.context.Mesa.Select(Mesas => new MesaModel()
            {
                MesaId = Mesas.MesaId,
                Capacidad = Mesas.Capacidad,
                Estado = Mesas.Estado,
                CreationDate = Mesas.CreationDate

            }).ToList();
        }

        public async Task<MesaModel> GetMesa(int idMesa) 
        {
            var mesa = await this.context.Mesa.FindAsync(idMesa);

            if (mesa == null)
            {
                throw new MesaDbException("Mesa not found");
            }

            return new MesaModel()
            {
                MesaId = mesa.MesaId,
                Capacidad = mesa.Capacidad,
                Estado = mesa.Estado,
                CreationDate = mesa.CreationDate

            };

        }


    }

}
