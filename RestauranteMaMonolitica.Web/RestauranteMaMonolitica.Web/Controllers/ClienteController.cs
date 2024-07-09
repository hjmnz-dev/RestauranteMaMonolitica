using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using RestauranteMaMonolitica.Web.Data.Repositories;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.BL.Core;

namespace RestauranteMaMonolitica.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            var result = this.clienteService.GetClientes();

            if (!result.Success)
            {
                ViewBag.Message =  result.Message;
            }

            var clientes = (List<ClienteGetModel>)result.Data;
            return View(clientes);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            var cliente = this.clienteService.GetCliente(id);
            return View(cliente);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteSaveModel clienteSave)
        {
            try
            {
                clienteSave.creation_date = DateTime.Now;
                this.clienteService.SaveClientes(clienteSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = this.clienteService.GetCliente(id);
            return View(cliente);
            
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteUpdateModel clienteUpdate)
        {
            try
            {
                clienteUpdate.modify_date = DateTime.Now;
                clienteUpdate.modify_user = 1;
                this.clienteService.UpdateClientes(clienteUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
