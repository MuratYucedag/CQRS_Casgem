using Microsoft.EntityFrameworkCore;

namespace CQRS_Casgem.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;initial catalog=CasgemCQRSDb;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
