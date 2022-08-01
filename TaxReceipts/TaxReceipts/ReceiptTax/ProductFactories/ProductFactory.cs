using TaxReceipts.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReceipts.ProductFactories
{
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct(string name, double price, bool imported, int quantity);
    }
}
