namespace WebAPIhelp.Models
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public Modelo ModeloPadre { get; set; }
    }
}