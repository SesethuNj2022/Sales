using TaxReceipts.ProductFactories;
using TaxReceipts.TaxCalculations;


namespace TaxReceipts.Products
{
    public class MedicalProduct : Product
    {

        public MedicalProduct()
            : base()
        {

        }

        public MedicalProduct(string name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }

        public override ProductFactory GetFactory()
        {
            return new MedicalProductFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.MEDICAL_TAX;
            else
                return 0;
        }
    }
}
