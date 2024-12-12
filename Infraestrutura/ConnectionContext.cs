using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Biomassa> Biomassa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
                "Server=localhost;" + 
                "Port=5432;Database=TesteFishTrader;" +
                "User Id=postgres;" +
                "Password=root");
    }    
}

