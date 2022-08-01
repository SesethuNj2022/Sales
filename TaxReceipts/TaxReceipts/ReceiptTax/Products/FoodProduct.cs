using TaxReceipts.ProductFactories;
using TaxReceipts.TaxCalculations;


namespace TaxReceipts.Products
{
    public class FoodProduct : Product
    {
        public FoodProduct()
            : base()
        {

        }

        public FoodProduct(string name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }

        public override ProductFactory GetFactory()
        {
            return new FoodProductFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.FOOD_TAX;
            else
                return 0;
        }
    }
}
