using System.Data.SqlTypes;

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}