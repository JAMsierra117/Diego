using Diego.Models.Catalogos;
using Microsoft.EntityFrameworkCore;
namespace Diego.Data
{
    public class CatalogosContext : DbContext
    {
        public CatalogosContext(DbContextOptions<CatalogosContext> options) : base(options)
        {            
        }

        public DbSet<Clasificacion> Clasificaciones { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Clasificacion>()
                .HasKey( k=> k.ID_Clasificacion);

            builder.Entity<Producto>()
                .HasKey( k=> k.ID_Producto);

            builder.Entity<Producto>()
                .HasOne(u => u.Clasificacion)
                .WithMany(u => u.Productos)                
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}