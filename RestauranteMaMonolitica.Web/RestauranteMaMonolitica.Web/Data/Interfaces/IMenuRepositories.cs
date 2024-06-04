using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IMenuRepositories
    {
        void Save(MenuSaveModel menuSave);
        void Uptade(MenuUpdateModel menuUpdate);
        void Remove(MenuRemoveModelcs menuRemoveModel);
        List<MenuModel> GetMenus();
        Task<MenuModel> GetMenu(int idMenu); 



    }
}
