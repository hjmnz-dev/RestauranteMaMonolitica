using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IMesaRepositories
    {
        void Save(MesaSaveModel mesaSave);
        void Update(MesaUpdateModel mesaUpdate);

        void Remove(MesaRemoveModel mesaRemove);

        List<MesaModel> GetMesas();

        Task<MesaModel> GetMesa(int idMesa);

    }
}
