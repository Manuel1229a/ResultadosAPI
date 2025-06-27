using Microsoft.EntityFrameworkCore;
using ResultadosAPI.Models;

namespace ResultadosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Resultado> Resultados { get; set; }

    }
}
