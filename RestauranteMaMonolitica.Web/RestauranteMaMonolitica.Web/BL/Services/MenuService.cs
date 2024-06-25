using Microsoft.Build.Framework;
using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.BL.MenuLog.Interfaces;
using RestauranteMaMonolitica.Web.BL.Validation;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.BL.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepositories menuRepositories;
        private readonly MenuVall menuVall;
        private readonly IMenuLogs _logger;

        public MenuService(IMenuRepositories menuRepositoriesDb, IMenuLogs logger)
        {
            this.menuRepositories = menuRepositoriesDb;
            _logger = (IMenuLogs?)logger;
        }

        public ServiceResult GetMenu(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                menuVall.MenuGetValidatios(id);
                result.Data = menuRepositories.GetMenu(id);
            }
            catch (Exception ex)
            {
                result.success = false;
                result.Messge = "Hubo un error al obtener los menus.";
                this._logger.LogError(result.Messge, ex.InnerException);
                this._logger.LogInformation(result.Messge);
            }
            return result;
        }

        public ServiceResult GetMenus()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                menuVall.MenuGetMenu();
                result.Data = menuRepositories.GetMenus();

            }
            catch (Exception ex)
            {
                result.success = false;
                result.Messge = "Hubo un error al obtener los Menus";
                this._logger.LogError(result.Messge, ex.InnerException);
                this._logger.LogInformation(result.Messge);
            }
            return result;
        }

        public ServiceResult RemoveMenu(MenuRemoveModelcs menuRemoveModelcs)
        {
            ServiceResult result = new ServiceResult();

            try
            {

                this.menuRepositories.Remove(menuRemoveModelcs);
            }
            catch(Exception ex)
            {
                result.success = false;
                result.Messge = "No se pudo eliminar un Menu";
            }
            return result;
        }

        public ServiceResult SaveMenu(MenuSaveModel menuSaveModel)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                menuVall.MenuSaveValidation(menuSaveModel);
                this.menuRepositories.Save(menuSaveModel);

            }
            catch (Exception ex)
            {
                result.success = false;
                result.Messge = "No se pudo Guardar";
                this._logger.LogError(result.Messge, ex.InnerException);
                this._logger.LogInformation(result.Messge);
            }
            return result;
        }

        public ServiceResult UptadeMenu(MenuUpdateModel menuUpdateModel)
        {

            ServiceResult result = new ServiceResult();

            try
            {
                menuVall.MenuUpdateValidation(menuUpdateModel);
                this.menuRepositories.Uptade(menuUpdateModel);
            }
            
            catch (Exception ex)
            {
                result.success = false;
                result.Messge = "No se pudo Actualizar un menu";
                this._logger.LogError(result.Messge, ex.InnerException);
                this._logger.LogInformation(result.Messge);
            }
            return result;
        }
    }
}
