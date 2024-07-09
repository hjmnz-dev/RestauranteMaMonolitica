using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using RestauranteMaMonolitica.Web.Data.Models.Empleado;
using RestauranteMaMonolitica.Web.Data.Repositories;

namespace RestauranteMaMonolitica.Web.Controllers
{
    public class EmpleadoController : Controller
    {

        private readonly IEmpleadoService empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService)
        {
            this.empleadoService = empleadoService;
        }

        // GET: EmpleadoController
        public ActionResult Index()
        {
            var empleados = this.empleadoService.GetEmpleados();
            return View(empleados);
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            var empleado = this.empleadoService.GetEmpleado(id);
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
                this.empleadoService.SaveEmpleados(empleadoSave);
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
            var empleado = this.empleadoService.GetEmpleado(id);
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
                this.empleadoService.UpdateEmpleados(empleadoUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
