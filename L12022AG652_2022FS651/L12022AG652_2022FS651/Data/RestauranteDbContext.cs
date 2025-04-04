using Microsoft.EntityFrameworkCore;
using L12022AG652_2022FS651.Models;

namespace L012022AG652_2022FS651.Data
{
    public class RestauranteDbContext : DbContext
    {
        public RestauranteDbContext(DbContextOptions<RestauranteDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
    }
}

