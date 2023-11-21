namespace Presentacion.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }="";
        public decimal Precio { get; set; }

        public string descripcion { get; set; }="";
        public bool stock;
    }
}
