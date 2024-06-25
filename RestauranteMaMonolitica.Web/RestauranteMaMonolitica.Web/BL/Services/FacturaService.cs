using Microsoft.CodeAnalysis.CSharp.Syntax;
using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.BL.Exceptions;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.Data.DbObjects;
using RestauranteMaMonolitica.Web.Data.Helpers;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;
using System.Reflection.Metadata.Ecma335;
namespace RestauranteMaMonolitica.Web.BL.Services
{
    public class FacturaService : IFacturaService
    {

        private readonly IFacturaDb FacturaDb;
        private readonly ILogger<FacturaService> logger;

        public FacturaService (IFacturaDb FacturaDb, ILogger<FacturaService> logger) 
        { 
             this.FacturaDb = FacturaDb;
             this.logger = logger;
        }

        public FacturaServiceResult GetFacturas() 
        { 
           FacturaServiceResult result = new FacturaServiceResult();

            try
            {
               result.Data = FacturaDb.GetFacturas();
            }
            catch (Exception ex)
            {

                result.Sucess = false;
                result.Message = "Ocurrio un error obteniendo las Facturas";
                this.logger.LogError(result.Message, ex.ToString());    
            }

            return result;
            
        }

           public FacturaServiceResult GetFactura(int id) 
        
            {
            FacturaServiceResult result = new FacturaServiceResult();

            try
            {
                result.Data = FacturaDb.GetFactura(id);

            }
            catch (Exception ex)
            {

                result.Sucess = false;
                result.Message = "Ocurrio un error obteniendo las Facturas";
                this.logger.LogError(result.Message, ex.ToString());
            }

            return result;
        
            }


        public FacturaServiceResult updateFactura(FacturaUpdateModel facturaUpdate) 
        {
            

            FacturaServiceResult result = new FacturaServiceResult();

            try
            {
                if (FacturaHelper.IsNullOrWhitespace(facturaUpdate, result, "La Factura no puede ser nulo."))
                    return result;

                if (FacturaHelper.IsInvalidDecimalLength(facturaUpdate.Total, result, "La longitud del numero debe ser de 10.", 10, 2))
                    return result;

                this.FacturaDb.updateFactura(facturaUpdate);
            }
            catch (Exception ex)
            {
                result.Sucess = false;
                result.Message = "Ocurrio un error Actualizando los Datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }

            return result;
           
        }

       public  FacturaServiceResult removeFactura(FacturaRemoveModel facturaRemove) 
        { 
            FacturaServiceResult result= new FacturaServiceResult();

            try
            {
                if (facturaRemove is null)
                {
                    result.Sucess = false;
                    result.Message = "La Factura no puede ser nulo.";
                    return result;
                }
                this.FacturaDb.removeFactura(facturaRemove);
            }
            catch (Exception ex)
            {
                result.Sucess = false;
                result.Message = ("Ocurrio un error removiendo los datos.");
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result;
        }

       public FacturaServiceResult saveFactura(FacturaSaveModel facturaSave) 
        {
            FacturaServiceResult result = new FacturaServiceResult();

            try
            {
                if (FacturaHelper.IsNullOrWhitespace(facturaSave, result, "La Factura no puede ser nulo."))
                    return result;

                if (FacturaHelper.IsInvalidDecimalLength(facturaSave.Total, result, "La longitud del numero debe ser de 10.", 10, 2))
                    return result;

                this.FacturaDb.saveFactura(facturaSave);
            }
            catch (Exception ex)
            {
                result.Sucess = false;
                result.Message = "Ocurrio un error Actualizando los Datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }

            return result; 
        }






    }
}
