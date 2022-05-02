using System.Data.Entity;
namespace EntityFrameworkDemo
{
    internal class TradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
