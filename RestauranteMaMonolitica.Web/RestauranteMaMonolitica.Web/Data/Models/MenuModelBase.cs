using System.ComponentModel.DataAnnotations;

namespace RestauranteMaMonolitica.Web.Data.Models
{
    public abstract class MenuModelBase 
    {

        [Key]
        public int? IdPlato { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public Decimal? Precio { get; set; }
        public string Categoria { get; set; }

    }
}
