using System;

namespace StoreV1
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            var random = new Random();
            ProductId = random.Next(1, 100000);
        }
    }
}