using System;
using TaxReceipts.ProductFactories;
using TaxReceipts.TaxCalculations;


namespace TaxReceipts.Products
{
    public class BookProduct : Product
    {

        public BookProduct()
            : base()
        {
        }

        public BookProduct(string name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {

        }

        public override ProductFactory GetFactory()
        {
            return new BookProductFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.BOOK_TAX;
            else
                return 0;
        }
    }
}
