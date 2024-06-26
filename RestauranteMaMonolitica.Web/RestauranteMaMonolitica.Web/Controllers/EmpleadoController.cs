using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using RestauranteMaMonolitica.Web.Data.Models.Empleado;
using RestauranteMaMonolitica.Web.Data.Repositories;

namespace RestauranteMaMonolitica.Web.Controllers
{
    public class EmpleadoController : Controller
    {

        private readonly EmpleadoRepositories empleadoRepositories;

        public EmpleadoController(EmpleadoRepositories empleadoRepositories)
        {
            this.empleadoRepositories = empleadoRepositories;
        }

        // GET: EmpleadoController
        public ActionResult Index()
        {
            var empleados = this.empleadoRepositories.GetEmpleados();
            return View(empleados);
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            var empleado = this.empleadoRepositories.GetEmpleado(id);
            return View(empleado);
        }

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpleadoSaveModel empleadoSave)
        {
            try
            {
                empleadoSave.creation_date = DateTime.Now;
                this.empleadoRepositories.SaveEmpleado(empleadoSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            var empleado = this.empleadoRepositories.GetEmpleado(id);
            return View(empleado);
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadoUpdateModel empleadoUpdate)
        {
            try
            {
                empleadoUpdate.modify_date = DateTime.Now;
                empleadoUpdate.modify_user = 1;
                this.empleadoRepositories.UpdateEmpleado(empleadoUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
