namespace Presentacion.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }="";
        public string CorreoElectronico { get; set; }="";
        // Otras propiedades según sea necesario
        public string contrasenia { get; set; }="";
    }
}
