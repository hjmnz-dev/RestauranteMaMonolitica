using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RestauranteMaMonolitica.Web.Data.Entities;


namespace RestauranteMaMonolitica.Web.Data.Context
{
    public class RestauranteContext : DbContext
    {
        #region"Constructor"
        public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options)
        { }
        #endregion

        #region"Db Sets"
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        #endregion
        
    }
}
    

         

    

