using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkDemo
{
    internal class ProductDal
    {
        public List<Product> GetAllList()
        {
            using (TradeContext context = new TradeContext())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (TradeContext context=new TradeContext())
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (TradeContext context=new TradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (TradeContext context=new TradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
