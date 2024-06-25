using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.BL.Interfaces
{
    public interface IMenuService
    {

        ServiceResult GetMenus();

        ServiceResult GetMenu(int id);
        ServiceResult UptadeMenu(MenuUpdateModel menuUpdateModel);

        ServiceResult RemoveMenu(MenuRemoveModelcs menuRemoveModelcs);

        ServiceResult SaveMenu(MenuSaveModel menuSaveModel);
    }
}
