using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteMaMonolitica.Web.Data.DbObjects;

namespace RestauranteMaMonolitica.Web.Controllers
{
    public class MesaController1 : Controller
    {
        private readonly MesaDb mesaDb;

        public MesaController1(MesaDb mesaDb) 
        {
            this.mesaDb = mesaDb;
        }

        // GET: MesaController1
        public ActionResult Index()

        {
            var Mesa = this.mesaDb.GetMesas();
            return View(Mesa);
        }

        // GET: MesaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MesaController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesaController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MesaController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MesaController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MesaController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MesaController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
