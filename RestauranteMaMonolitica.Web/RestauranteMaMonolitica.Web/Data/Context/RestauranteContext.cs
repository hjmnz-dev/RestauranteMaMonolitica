using Microsoft.EntityFrameworkCore;
using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Context

   
{
    public class RestauranteContext : DbContext
    {


        public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options)
        
        {
        
        
        
        
        
        
        
        
        
        }

        #region "DbSets"
        public DbSet<Factura> Factura { get; set; }    
        #endregion









    }
}
