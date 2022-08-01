using System.Collections.Generic;
using TaxReceipts.Products;

namespace TaxReceipts.Shopping
{
    public class StoreShelf
    {
        private readonly Dictionary<string, Product> productItems;

        public StoreShelf()
        {
            productItems = new Dictionary<string, Product>();
            AddItemsToShelf("book", new BookProduct());
            AddItemsToShelf("music cd", new MiscellaneousProduct());
            AddItemsToShelf("chocolate bar", new FoodProduct());
            AddItemsToShelf("box of chocolates", new FoodProduct());
            AddItemsToShelf("bottle of perfume", new MiscellaneousProduct());
            AddItemsToShelf("packet of paracetamol", new MedicalProduct());
        }

        public void AddItemsToShelf(string productItem, Product productCategory)
        {
            productItems.Add(productItem, productCategory);
        }

        public Product SearchItems(string name, double price, bool imported, int quantity)
        {
            Product productItem = productItems[name].GetFactory().CreateProduct(name, price, imported, quantity);
            return productItem;
        }

        public int GetShelfSize()
        {
            return productItems.Count;
        }
    }
}
