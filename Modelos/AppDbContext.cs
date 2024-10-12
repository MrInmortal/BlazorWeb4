using Microsoft.EntityFrameworkCore;

namespace Tarea4.Modelos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Serie> Series { get; set; }
        // Otros DbSet que necesites
    }
}
