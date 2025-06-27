namespace ResultadosAPI.Models
{
    public class Resultado
    {
        public int id { get; set; }
        public double valor { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;
    }
}
