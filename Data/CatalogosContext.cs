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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Clasificacion>()
                .HasKey( k=> k.ID_Clasificacion);
        }
    }
}