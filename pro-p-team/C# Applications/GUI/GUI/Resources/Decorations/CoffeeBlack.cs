using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Resources.Decorations.DrinkDecorations
{
    public class CoffeeBlack : Decorator
    {
        private int productId;

        public CoffeeBlack(IProduct p)
        {
            Product = p;
        }
        public override decimal Cost()
        {
            return 2.00m + Product.Cost();
        }

        public override int GetProductId()
        {
            return productId;
        }

        public override int ProductCount()
        {
            return Product.ProductCount() - 950;
        }

        public override void ProductId(int id)
        {
            productId = id;
        }

        public override int StoreId()
        {
            return Product.StoreId();
        }
        public override string ToString()
        {
            return Product.ToString() + " Black Flavor";
        }
    }
}
