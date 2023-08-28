using Base.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Base.API.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> opts)
            : base(opts)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Sabor> Sabores { get; set; }
        public DbSet<Configuracao> Configuracoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }


    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Configuracao>().HasData(new Configuracao[]
            {
                new Configuracao {
                    Id = 1,
                    NomePix ="Rafael",
                    ChavePix = "rafhita1@gmail.com",
                    CidadePix = "Rio Claro",
                    ValorPequeno = 10m,
                    ValorMedio = 15m,
                    ValorGrande = 20m,
                    ValorEntrega = 1m,
                }
            });
        }
    }
}
