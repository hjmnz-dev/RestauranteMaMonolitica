using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Exceptions;
using RestauranteMaMonolitica.Web.Data.Models.Cliente;

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
                creation_user = clienteSaveModel.creation_user
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
                    clienteRemove.deleted = clienteRemoveModel.deleted;
                    clienteRemove.delete_date = clienteRemoveModel.delete_date;
                    clienteRemove.delete_user = clienteRemoveModel.delete_user;

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
                clienteUpdate.modify_date = clienteUpdateModel.modify_date;
                clienteUpdate.modify_user = clienteUpdateModel.modify_user;
                clienteUpdate.Nombre = clienteUpdateModel.Nombre;
                clienteUpdate.Telefono = clienteUpdateModel.Telefono;
                clienteUpdate.Email = clienteUpdateModel.Email;

                this.context.Update(clienteUpdate);
                this.context.SaveChanges();
            }
        }

        public ClienteGetModel GetCliente(int IdCliente)
        {
            var cliente = this.context.Cliente.Find(IdCliente);

            if (cliente == null)
            {
                throw new ClienteDbException("Cliente no encontrado");
            }
            
                return new ClienteGetModel()
                {
                    IdCliente = cliente.IdCliente,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email
                };
            }

        public List<ClienteGetModel> GetClientes()
        {
            return this.context.Cliente.Select(clientes => new ClienteGetModel()
            {
                IdCliente = clientes.IdCliente,
                Nombre = clientes.Nombre,
                Telefono = clientes.Telefono,
                Email = clientes.Email
            }).ToList();
        }

    }
}
