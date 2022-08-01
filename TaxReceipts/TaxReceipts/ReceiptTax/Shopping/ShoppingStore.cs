using System;
using TaxReceipts.Billing;
using TaxReceipts.Products;
using TaxReceipts.utils;


namespace TaxReceipts.Shopping
{
    public class ShoppingStore
    {
        private ShoppingCart shoppingCart;
        private StoreShelf storeShelf;
        private PaymentCounter paymentCounter;
        private string country;

        public ShoppingStore()
        {
            country = "Local";
            shoppingCart = new ShoppingCart();
            paymentCounter = new PaymentCounter(country);
            storeShelf = new StoreShelf();
        }

        public void GetAndPlaceInCart(string name, double price, bool imported, int quantity)
        {
            Product product = storeShelf.SearchItems(name, price, imported, quantity);
            shoppingCart.AddItemToCart(product);
        }

        public void GetOrder()
        {
            do
            {
                string name = GetProductName();
                double price = GetProductPrice();
                bool imported = IsProductImported();
                int quantity = GetQuantity();
                GetAndPlaceInCart(name, price, imported, quantity);
            }
            while (IsAddAnotherProduct());
        }

        public void CheckOut()
        {
            paymentCounter.BillItemsInCart(shoppingCart);
            Receipt receipt = paymentCounter.GetReceipt();
            paymentCounter.PrintReceipt(receipt);
        }

        public string GetProductName()
        {
            Console.WriteLine("Enter the product name:\n");
            return Console.ReadLine().ToLower();
        }

        public double GetProductPrice()
        {
            Console.WriteLine("Enter the product price:\n");
            var input = Console.ReadLine().ToLower();
            double val;
            if (!(double.TryParse(input, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.InvariantCulture, out val)))
            {
                Console.WriteLine("Invalid price. Enter a valid price");
            }

            return val;
        }

        public bool IsProductImported()
        {
            Console.WriteLine("Is the product imported or not?(y/n)\n");
            var input = Console.ReadLine().ToLower();
            bool isValid = false;
            if (!isValid)
            {
                if (input == "y")
                    isValid = true;
                else if (input == "n")
                    isValid = true;
                else
                    Console.WriteLine("Invalid input. Enter (y/n)");
            }

            if (input == "y")
                return true;
            else
                return false;
        }

        public int GetQuantity()
        {
            Console.WriteLine("Enter the quantity:\n");
            var input = Console.ReadLine().ToLower();
            
            int intVal;
            if (!(int.TryParse(input, out intVal)))
            {
                Console.WriteLine("Invalid input. Enter a valid qauntity");
            }
            return intVal;
        }

        public bool IsAddAnotherProduct()
        {
            Console.WriteLine("Add another Product?(y/n)");

            var input = Console.ReadLine().ToLower();
            if (!(input == "y" || input == "n"))
            {
                Console.WriteLine("Invalid input. Enter (y/n)");
            }

            bool addAnotherProduct = TaxUtil.ParseBoolean(Convert.ToChar(input));
            return addAnotherProduct;
        }
    }
}
