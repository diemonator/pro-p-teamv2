using System;

namespace GUI.Resources.FoodDecorator
{
    public class Fries : Decorator
    {
        private int productId;

        public Fries(IProduct p)
        {
            Product = p;
        }
        public override decimal Cost()
        {
            return 2m + Product.Cost();
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
            return Product.ToString() + " with Fries";
        }

    }
}
