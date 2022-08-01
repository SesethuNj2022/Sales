

namespace TaxReceipts.ProductFactories
{
    public class BookProductFactory : ProductFactory
    {
        public override Products.Product CreateProduct(string name, double price, bool imported, int quantity)
        {
            return new Products.BookProduct(name, price, imported, quantity);
        }
    }
}
