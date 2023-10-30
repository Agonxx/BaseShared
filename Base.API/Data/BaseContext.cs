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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().HasData(new Usuario[]
            {
                new Usuario {
                    Id = 1,
                    Email = "Rafhita1@gmail.com",
                    Genero = Shared.Enums.ComumEnums.EGenero.Masculino,
                    Nome = "Rafael",
                    Apelido = "Agon",
                }
            });
        }
    }
}
