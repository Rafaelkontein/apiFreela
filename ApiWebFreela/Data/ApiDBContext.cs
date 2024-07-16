using ApiWebFreela.Modell;
using Microsoft.EntityFrameworkCore;
namespace ApiWebFreela.Data
{
    public class ApiDBContext: DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options ): base(options)
        { 
        }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
