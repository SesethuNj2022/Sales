using System;
using TaxReceipts.Shopping;

namespace TaxReceipts
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingStore store = new ShoppingStore();
            store.GetOrder();
            store.CheckOut();

            Console.ReadKey();
        }
    }
}
