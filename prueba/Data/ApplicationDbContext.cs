using Microsoft.EntityFrameworkCore;
using prueba.Models;

namespace prueba.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        // DbSet que representa la tabla "Productos" en la base de datos
        public DbSet<Producto> Productos { get; set; }
    }
}

