using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Data.Interfaces
{
    public interface IMenuDb 
    {
        void Save(MenuSaveModel menuSave);
        void Uptade(MenuUpdateModel menuUpdate);
        void Remove(MenuRemoveModelcs menuRemoveModel);
        List<MenuModel> GetMenus();
        MenuModel GetMenu(int idMenu);
    }
}
