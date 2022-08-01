using TaxReceipts.ProductFactories;
using TaxReceipts.TaxCalculations;


namespace TaxReceipts.Products
{
    public class MiscellaneousProduct : Product
    {
        public MiscellaneousProduct()
            : base()
        {
        }
        public MiscellaneousProduct(string name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }
        public override ProductFactory GetFactory()
        {
            return new MiscellaneousProductFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.MISC_TAX;
            else
                return 0;
        }
    }
}
