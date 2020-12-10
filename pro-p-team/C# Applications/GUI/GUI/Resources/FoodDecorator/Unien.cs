using System;

namespace GUI.Resources.FoodDecorator
{
    public class Unien : Decorator
    {
        private int productId;

        public Unien(IProduct p)
        {
            Product = p;
        }
        public override decimal Cost()
        {
            return 2.70m + Product.Cost();
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
            return Product.ToString() + " with Union";
        }


    }
}
