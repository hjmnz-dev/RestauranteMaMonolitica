using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.BL.IMenuVal
{
    public interface IMenuVall
    {

        void MenuUpdateValidation(MenuUpdateModel menuUpdate);
        void MenuSaveValidation(MenuSaveModel menuSave);
        void MenuGetMenu();
        void MenuGetValidatios(int id);

    }
}
