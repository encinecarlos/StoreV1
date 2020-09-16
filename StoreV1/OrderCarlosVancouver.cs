using StoreV1.Interfaces;

namespace StoreV1
{
    public class OrderCarlosVancouver : OrderContract
    {
        public override ITax Tax { get; set; }
        public OrderCarlosVancouver()
        {
            Tax = new VancouverTax();
        }

        public void SetProducts()
        {
            var product1 = new Product
            {
                Name = "Mesa Gamer",
                Price = 470
            };

            var product2 = new Product
            {
                Name = "Cadeira gamer",
                Price = 560
            };

            Products.Add(product1);
            Products.Add(product2);
        }

        public override void SetTax(ITax tax)
        {
            Tax = tax;
        }
    }
}