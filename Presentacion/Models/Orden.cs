using System;
using System.Collections.Generic;

namespace Presentacion.Models
{
    public class Orden
    {
        public int Id { get; set; }
        public DateTime FechaOrden { get; set; }
        public Usuario? Usuario { get; set; }
        public List<Producto> Productos { get; set; }
        // Otras propiedades según sea necesario
         public int idcurier { get; set; }
        public decimal total { get; set; }
    }
}
