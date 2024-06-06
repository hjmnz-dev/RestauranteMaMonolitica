using Microsoft.EntityFrameworkCore;
using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Context
{
    public class RestauranteContext : DbContext

    { 

    #region"Constructor"
    public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options)
    {


    }
    #endregion


    #region "Db Sets"
    public DbSet<Mesa> Mesa { get; set; }
    #endregion

    }


}



