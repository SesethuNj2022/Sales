using TaxReceipts.Products;


namespace TaxReceipts.ProductFactories
{
    public class FoodProductFactory : ProductFactory
    {
        public override Product CreateProduct(string name, double price, bool imported, int quantity)
        {
            return new FoodProduct(name, price, imported, quantity);
        }
    }
}
