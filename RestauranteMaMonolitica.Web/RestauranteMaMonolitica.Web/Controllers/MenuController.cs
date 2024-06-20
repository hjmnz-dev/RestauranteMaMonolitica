using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteMaMonolitica.Web.Data.DbObjects;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuRepositories _menuRepository;

        public MenuController(IMenuRepositories menuRepository)
        {
            _menuRepository = menuRepository;
        }
        // GET: MenuController
        public ActionResult Index()
        {
            var menus = _menuRepository.GetMenus();
            return View(menus);
        }

        // GET: MenuController/Details/5
        public ActionResult Details(int id)
        {

            var menu = this._menuRepository.GetMenu(id);

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
                this._menuRepository.Save(menuSaveMode);
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

            var menu = this._menuRepository.GetMenu(id);
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

                this._menuRepository.Uptade(menuUpdateModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
