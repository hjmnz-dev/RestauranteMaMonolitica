using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Exceptions;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;
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

        public void saveFactura(FacturaSaveModel facturaSaveModel)
        {
            var factura = new Factura();
            FacturaHelper.MapFacturaSaveModel(facturaSaveModel, factura);

            context.Factura.Add(factura);
            context.SaveChanges();
        }

        public void updateFactura(FacturaUpdateModel updateModel)
        {
            Factura facturaToUpdate = FacturaHelper.FindFacturaById(context, updateModel.idFactura);

            facturaToUpdate.ModifyDate = updateModel.ModifyDate;
            facturaToUpdate.ModifyUser = updateModel.ModifyUser;
            facturaToUpdate.Fecha = updateModel.Fecha;
            facturaToUpdate.Total = updateModel.Total;

            context.Factura.Update(facturaToUpdate);
            context.SaveChanges();
        }

        public void removeFactura(FacturaRemoveModel facturaRemove)
        {
            Factura facturaToDelete = FacturaHelper.FindFacturaById(context, facturaRemove.idFactura);

            facturaToDelete.Deleted = facturaRemove.Deleted;
            facturaToDelete.DeletedDate = facturaRemove.DeletedDate;
            facturaToDelete.DeletedUser = facturaRemove.DeletedUser;

            context.Factura.Update(facturaToDelete);
            context.SaveChanges();
        }

        public List<FacturaModel> GetFacturas()
        {
            return context.Factura.Select(factura => FacturaHelper.MapToFacturaModel(factura)).ToList();
        }

        public FacturaModel GetFactura(int idFactura)
        {
            var factura = FacturaHelper.FindFacturaById(context, idFactura);
            return FacturaHelper.MapToFacturaModel(factura);
        }
    }
}
