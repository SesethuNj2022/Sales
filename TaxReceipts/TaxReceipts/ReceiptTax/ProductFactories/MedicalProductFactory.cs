using TaxReceipts.Products;


namespace TaxReceipts.ProductFactories
{
    public class MedicalProductFactory : ProductFactory
    {
        public override Product CreateProduct(string name, double price, bool imported, int quantity)
        {
            return new MedicalProduct(name, price, imported, quantity);
        }
    }
}
