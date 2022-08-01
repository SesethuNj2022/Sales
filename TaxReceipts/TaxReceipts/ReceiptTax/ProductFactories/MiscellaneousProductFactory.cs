using TaxReceipts.Products;


namespace TaxReceipts.ProductFactories
{
    public class MiscellaneousProductFactory : ProductFactory
    {
        public override Product CreateProduct(string name, double price, bool imported, int quantity)
        {
            return new MiscellaneousProduct(name, price, imported, quantity);
        }
    }
}
