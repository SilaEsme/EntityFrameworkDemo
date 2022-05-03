using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkDemo
{
    internal class ProductDal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>All Product table</returns>
        public List<Product> GetAllList()
        {
            using (TradeContext context = new TradeContext())
            {
                return context.Products.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product which matches with @param</returns>
        public Product GetById(int id)
        {
            using (TradeContext context = new TradeContext())
            {
                return context.Products.SingleOrDefault(p => p.Id == id);
            }
        }

        /// <summary>
        /// Selects filtered products by name.
        /// </summary>
        /// <param name="key">Search value</param>
        /// <returns>Filtered products list</returns>
        public List<Product> GetByName(string key)
        {
            using (TradeContext context=new TradeContext())
            {
                return context.Products.Where(x => x.Name.Contains(key)).ToList();      // Database filtering
            }
        }

        /// <summary>
        /// Selects filtered products by minimum price
        /// </summary>
        /// <param name="price">Minimum price</param>
        /// <returns>Filtered products list</returns>
        public List<Product> GetByPrice(int price)
        {
            using (TradeContext context = new TradeContext())
            {
                return context.Products.Where(x => Convert.ToInt32(x.Price) >= price).ToList();
            }
        }

        /// <summary>
        /// Selects filtered products between minimum and maximum price
        /// </summary>
        /// <param name="priceMin">Minimum price</param>
        /// <param name="priceMax">Maximum price</param>
        /// <returns>Filtered products list</returns>
        public List<Product> GetByPrice(int priceMin, int priceMax)
        {
            using (TradeContext context=new TradeContext())
            {
                return context.Products.Where(x=> Convert.ToInt32(x.Price) >= priceMin &&  Convert.ToInt32(x.Price) <= priceMax).ToList();
            }
        }

        public void Add(Product product)
        {
            using (TradeContext context = new TradeContext()) 
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
