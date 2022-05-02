using System.Data.Entity;
namespace EntityFrameworkDemo
{
    public class TradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
