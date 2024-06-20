using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Exceptions;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;
using RestauranteMaMonolitica.Web.Data.Core;
using RestauranteMaMonolitica.Web.Data.Helpers;

namespace RestauranteMaMonolitica.Web.Data.DbObjects
{
    public class FacturaDb : IFacturaDb
    {
        private readonly RestauranteContext context;

        public FacturaDb(RestauranteContext context)
        {
            this.context = context;
        }

        public void saveFactura(FacturaSaveModel facturaSave)
        {
            Factura factura = new Factura();
            FacturaHelper.MapFacturaSaveModel(facturaSave, factura);

            context.Factura.Add(factura);
            context.SaveChanges();
        }

        public void updateFactura(FacturaUpdateModel updateModel)
        {
            Factura facturaToUpdate = FacturaHelper.FindFacturaById(context, updateModel.IdFactura);
            
            facturaToUpdate.modify_date = updateModel.ChangeDate;
            facturaToUpdate.modify_user = updateModel.ChangeUser;
            facturaToUpdate.Fecha = updateModel.Fecha;
            facturaToUpdate.Total = updateModel.Total;

            context.Factura.Update(facturaToUpdate);
            context.SaveChanges();
        }

        public void removeFactura(FacturaRemoveModel facturaRemove)
        {
            Factura facturaToDelete = FacturaHelper.FindFacturaById(context, facturaRemove.IdFactura);

            facturaToDelete.deleted = facturaRemove.deleted;
            facturaToDelete.delete_date = facturaRemove.delete_date;
            facturaToDelete.delete_user = facturaRemove.delete_user;

            context.Factura.Update(facturaToDelete);
            context.SaveChanges();
        }

        public List<FacturaGetModel> GetFacturas()
        {
            return context.Factura.Select(factura => FacturaHelper.MapToFacturaModel(factura)).ToList();
        }

        public FacturaGetModel GetFactura(int idFactura)
        {
            var factura = FacturaHelper.FindFacturaById(context, idFactura);
            return FacturaHelper.MapToFacturaModel(factura);
        }
    }
}
