using Microsoft.EntityFrameworkCore;
using RestauranteMaMonolitica.Web.Data.Entities;

namespace RestauranteMaMonolitica.Web.Data.Context
{
    public class RestauranteContext : DbContext
    {
        public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options){  }

        #region"Db set"
        public DbSet<Menu> Menu { get; set; }

        #endregion
    }
}
