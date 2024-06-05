﻿using RestauranteMaMonolitica.Web.Data.Core;

namespace RestauranteMaMonolitica.Web.Data.Models
{
    public class FacturaModel : FacturaBaseEntity
    {

        public int idFactura { get; set; }
       

        public int idPedido { get; set; }

        public string? Pedido { get; set;}
    }
}
