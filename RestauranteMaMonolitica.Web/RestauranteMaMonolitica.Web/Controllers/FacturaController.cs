using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Controllers
{
    
    public class FacturaController : Controller
    {
        private readonly IFacturaService facturaService;

        public FacturaController(IFacturaService facturaService) 
        {
           
            this.facturaService = facturaService;
           
        }
        // GET: FacturaController
        public ActionResult Index()
        {
            var result = this.facturaService.GetFacturas();
            if (!result.Sucess) 
            
            ViewBag.Message = result.Message;

            var factura = (List<FacturaGetModel>)result.Data;
            return View(factura);
            
        }

        // GET: FacturaController/Details/5
        public ActionResult Details(int id)
        {

            var result = facturaService.GetFactura(id);

            if (!result.Sucess)
            
              
                ViewBag.Message = result.Message;
            

            var factura = result.Data as FacturaGetModel;

           

            return View(factura);
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
                this.facturaService.saveFactura(facturaSave);
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
            var result = facturaService.GetFactura(id);

            if (!result.Sucess)


                ViewBag.Message = result.Message;


            var factura = result.Data as FacturaGetModel;



            return View(factura);
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
                this.facturaService.updateFactura(facturaUpdateModel);
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
