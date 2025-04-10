using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace PitchWin.Modelo
{
    public class PitchWinDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Apuesta> Apuestas { get; set; }
        public DbSet<Reporte> Reportes { get; set; }  // Sólo una propiedad para Reporte

        // Constructor sin parámetros: obtiene la cadena desde app.config
        public PitchWinDbContext() : base(GetOptions()) { }

        // Constructor para inyección de dependencias
        public PitchWinDbContext(DbContextOptions<PitchWinDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar la entidad Reporte como keyless
            modelBuilder.Entity<Reporte>().HasNoKey();

            // Mapea otros modelos si es necesario.
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");

            // Ejemplo de configuración adicional (puedes personalizarlo)
            modelBuilder.Entity<Usuario>()
                .Property(u => u.Contrasena)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Ticket>()
                .Property(t => t.EquipoLocal)
                .IsRequired();
            modelBuilder.Entity<Ticket>()
                .Property(t => t.EquipoVisitante)
                .IsRequired();
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        }

        private static DbContextOptions<PitchWinDbContext> GetOptions()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PitchWinDbContext>();
            optionsBuilder.UseSqlServer(GetConnectionString());
            return optionsBuilder.Options;
        }
    }
}
