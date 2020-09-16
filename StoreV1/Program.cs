using System;
using System.Threading;

namespace StoreV1
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new OrderCarlosVancouver();
            order.SetProducts();
            Console.WriteLine("- List of products: ");
            order.GetProductList();
            Console.WriteLine("- Total: ");
            order.GetTotal();
            Console.WriteLine("- Location: ");
            order.GetLocation();

            Thread.Sleep(100000);
            Console.WriteLine("It's OK!");
        }
    }
}
