﻿using Microsoft.EntityFrameworkCore;
using L012022AG652_2022FS651.Models;
using L12022AG652_2022FS651.Models;

namespace L012022AG652_2022FS651.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
    }
}

