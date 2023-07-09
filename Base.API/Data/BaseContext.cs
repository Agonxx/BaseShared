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
    }
}
