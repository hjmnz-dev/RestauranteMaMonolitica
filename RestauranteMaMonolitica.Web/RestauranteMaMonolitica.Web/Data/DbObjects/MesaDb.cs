using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;
using RestauranteMaMonolitica.Web.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestauranteMaMonolitica.Web.Data.DbObjects
{
    public class MesaDb : IMesaRepositories

    {
        private readonly MesaRepositories _mesaRepositories;

        public MesaDb(MesaRepositories mesaRepositories)
        {
            _mesaRepositories = mesaRepositories;
        }

        public List<MesaModel> GetMesas()
        {
            return _mesaRepositories.GetMesas();
        }

        public void Save(MesaSaveModel mesaSaveModel)
        {
            _mesaRepositories.Save(mesaSaveModel);
        }

        public void Remove(MesaRemoveModel mesaRemoveModel)
        {
            _mesaRepositories.Remove(mesaRemoveModel);
        }

        public void Update(MesaUpdateModel mesaUpdate)
        {
            _mesaRepositories.Update(mesaUpdate);
        }

        public async Task<MesaModel> GetMesa(int idMesa)
        {
            return await _mesaRepositories.GetMesa(idMesa);

        }
    }
}

