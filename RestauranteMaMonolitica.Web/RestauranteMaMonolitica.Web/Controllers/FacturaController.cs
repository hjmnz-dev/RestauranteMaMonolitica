using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Controllers
{
    
    public class FacturaController : Controller
    {
        private readonly IFacturaDb facturaDb;

        public FacturaController(IFacturaDb facturaDb) 
        {
           this.facturaDb = facturaDb;
           
        }
        // GET: FacturaController
        public ActionResult Index()
        {
            var Factura = this.facturaDb.GetFacturas();
            return View(Factura);
        }

        // GET: FacturaController/Details/5
        public ActionResult Details(int id)
        {
            var Factura = facturaDb.GetFactura(id);
            return View(Factura);
        }

        // GET: FacturaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacturaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FacturaSaveModel facturaSave)
        {
            try
            {   facturaSave.ChangeDate = DateTime.Now;
                facturaSave.ChangeUser = 1;
                this.facturaDb.saveFactura(facturaSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FacturaController/Edit/5
        public ActionResult Edit(int id)
        {
            var Factura = facturaDb.GetFactura(id);
            return View(Factura);
        }

        // POST: FacturaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FacturaUpdateModel facturaUpdateModel)
        {
            try
            {
               facturaUpdateModel.ChangeDate = DateTime.Now;
               facturaUpdateModel.ChangeUser = 1;
                this.facturaDb.updateFactura(facturaUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FacturaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FacturaController/Delete/5
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
