using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Exceptions;
using RestauranteMaMonolitica.Web.Data.Models;


namespace RestauranteMaMonolitica.Web.Data.Helpers
{

    //si le soy honesto profe cree esta clase porque no estaba seguro de donde colocar estos metodos
    public static class FacturaHelper
    {
        public static Factura FindFacturaById(RestauranteContext context, int IdFactura)
        {
            var factura = context.Factura.Find(IdFactura);

            if (factura == null)
            {
                throw new FacturaDbException($"No se encontro el departamento con el id {IdFactura}");
            }

            return factura;
        }

        public static FacturaGetModel MapToFacturaModel(Factura factura)
        {
            
            return new FacturaGetModel
            {
                
                IdFactura = factura.IdFactura,
                Fecha = factura.Fecha,
                Total = factura.Total,
                creation_date = factura.creation_date
            };

        }

        public static void MapFacturaSaveModel(FacturaSaveModel saveModel, Factura factura)
        {
        
            factura.Total = saveModel.Total;
            factura.Fecha = saveModel.Fecha;
            factura.creation_date = saveModel.ChangeDate;
            factura.creation_user = saveModel.ChangeUser;
        }

    }
}

    