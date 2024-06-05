using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Exceptions;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.Data.Helpers
{

    //si le soy honesto profe cree esta clase porque no estaba seguro de donde colocar estos metodosw
    public static class FacturaHelper
    {
        public static Factura FindFacturaById(RestauranteContext context, int idFactura)
        {
            var factura = context.Factura.Find(idFactura);

            if (factura == null)
            {
                throw new FacturaDbException("La factura no se encuentra registrada");
            }

            return factura;
        }

        public static FacturaModel MapToFacturaModel(Factura factura)
        {
            return new FacturaModel
            {
                idFactura = factura.idFactura,
                idPedido = factura.idPedido,
                Fecha = factura.Fecha,
                Total = factura.Total
            };
        }

        public static void MapFacturaSaveModel(FacturaSaveModel saveModel, Factura factura)
        {
            factura.Total = saveModel.Total;
            factura.Fecha = saveModel.Fecha;
            factura.CreationDate = saveModel.CreationDate;
            factura.CreationUser = saveModel.CreationUser;
        }

    }
}

