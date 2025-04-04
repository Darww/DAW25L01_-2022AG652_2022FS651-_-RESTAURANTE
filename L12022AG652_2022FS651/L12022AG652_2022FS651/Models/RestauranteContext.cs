using Microsoft.EntityFrameworkCore;

namespace L12022AG652_2022FS651.Models
{
        public class RestauranteContext : DbContext
        {
            public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options) { }

            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Plato> Platos { get; set; }
            public DbSet<Motorista> Motoristas { get; set; }
            public DbSet<Pedidos> Pedidos { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Pedidos>()
                    .HasOne(p => p.Cliente)
                    .WithMany()
                    .HasForeignKey(p => p.ClienteId);

                modelBuilder.Entity<Pedidos>()
                    .HasOne(p => p.Plato)
                    .WithMany()
                    .HasForeignKey(p => p.PlatoId);

                modelBuilder.Entity<Pedidos>()
                    .HasOne(p => p.Motorista)
                    .WithMany()
                    .HasForeignKey(p => p.MotoristaId);
            }
        }
}
