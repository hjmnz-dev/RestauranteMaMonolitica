using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;
using RestauranteMaMonolitica.Web.Data.Repositories;

namespace RestauranteMaMonolitica.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteRepositories clienteRepositories;

        public ClienteController(ClienteRepositories clienteRepositories)
        {
            this.clienteRepositories = clienteRepositories;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            var clientes = this.clienteRepositories.GetClientes();
            return View(clientes);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            var cliente = this.clienteRepositories.GetCliente(id);
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
                this.clienteRepositories.SaveCliente(clienteSave);
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
            var cliente = this.clienteRepositories.GetCliente(id);
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
                this.clienteRepositories.UpdateCliente(clienteUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
