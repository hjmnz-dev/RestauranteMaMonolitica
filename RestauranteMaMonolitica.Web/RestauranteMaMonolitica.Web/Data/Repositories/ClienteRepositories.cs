using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;
using RestauranteMaMonolitica.Web.Data.Exceptions;

namespace RestauranteMaMonolitica.Web.Data.Repositories
{
    public class ClienteRepositories : IClienteDb
    {
        private readonly RestauranteContext context;

        public ClienteRepositories(RestauranteContext context)
        {
            this.context = context;
        }

        public void SaveCliente(ClienteSaveModel clienteSaveModel)
        {
            Cliente cliente = new Cliente()
            {
                IdCliente = clienteSaveModel.IdCliente,
                Nombre = clienteSaveModel.Nombre,
                Telefono = clienteSaveModel.Telefono,
                Email = clienteSaveModel.Email,
                CreationUser = clienteSaveModel.CreationUser
            };

            this.context.Cliente.Add(cliente);
            this.context.SaveChanges();
        }

        public void RemoveCliente(ClienteRemoveModel clienteRemoveModel)
        {
            Cliente clienteRemove = this.context.Cliente.Find(clienteRemoveModel.IdCliente);
            {
                if (clienteRemove is null)
                {
                    throw new ClienteDbException("Error a la hora de borrar cliente");
                }
                else
                {
                    clienteRemove.Deleted = clienteRemoveModel.Deleted;
                    clienteRemove.DeleteDate = clienteRemoveModel.DeleteDate;
                    clienteRemove.DeleteUser = clienteRemoveModel.DeleteUser;

                    this.context.Cliente.Update(clienteRemove);
                    this.context.SaveChanges();
                }
                
            }
        }

       

        public void UpdateCliente(ClienteUpdateModel clienteUpdateModel)
        {
            if (clienteUpdateModel is null)
            {
                throw new ClienteDbException("Hubo un error al actualizar el cliente");
            }
            else {
                Cliente clienteUpdate = this.context.Cliente.Find(clienteUpdateModel.IdCliente);
                clienteUpdate.ModifyDate = clienteUpdateModel.ModifyDate;
                clienteUpdate.UserMod = clienteUpdateModel.UserMod;
                clienteUpdate.Nombre = clienteUpdateModel.Nombre;
                clienteUpdate.Telefono = clienteUpdateModel.Telefono;
                clienteUpdate.Email = clienteUpdateModel.Email;

                this.context.Update(clienteUpdate);
                this.context.SaveChanges();
            }
        }

        public async Task<ClienteModel> GetCliente(int IdCliente)
        {
            var cliente = await this.context.Cliente.FindAsync(IdCliente);

            if (cliente == null)
            {
                throw new ClienteDbException("Cliente no encontrado");
            }
            else {
                return new ClienteModel()
                {
                    IdCliente = cliente.IdCliente,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email
                };
            }

        }

        public List<ClienteModel> GetClientes()
        {
            return this.context.Cliente.Select(clientes => new ClienteModel() { 
            IdCliente = clientes.IdCliente,
            Nombre = clientes.Nombre,
            Telefono= clientes.Telefono,
            Email = clientes.Email
            }).ToList();
        }
    }
}
