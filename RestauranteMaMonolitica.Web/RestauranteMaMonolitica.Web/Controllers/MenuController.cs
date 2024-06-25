using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.Data.DbObjects;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService menuService;

        public MenuController(IMenuService menuService)
        {
            menuService = menuService;
            
        }
        // GET: MenuController
        public ActionResult Index()
        {
            var menus = menuService.GetMenus();
            return View(menus);
        }

        // GET: MenuController/Details/5
        public ActionResult Details(int id)
        {

            var menu = this.menuService.GetMenu(id);

            return View(menu);
        }

        // GET: MenuController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MenuSaveModel menuSaveMode)
        {
            try
            {
                menuSaveMode.creation_date = DateTime.Now;
                menuSaveMode.creation_user = 1;
                this.menuService.SaveMenu(menuSaveMode);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {

            var menu = this.menuService.GetMenu(id);
            return View(menu);
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MenuUpdateModel menuUpdateModel)
        {
            try
            {
                menuUpdateModel.ModifyDate = DateTime.Now;
                menuUpdateModel.CreationUser = 1;

                this.menuService.UptadeMenu(menuUpdateModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
