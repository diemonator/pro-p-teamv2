using System;

namespace GUI.Resources.Food
{
    public class Sandwitch : IProduct
    {
        private int productId;

        public decimal Cost()
        {
            return 4.99m;
        }

        public int GetProductId()
        {
            return productId;
        }

        public int ProductCount()
        {
            return 1000;
        }

        public void ProductId(int id)
        {
            productId = id;
        }

        public int StoreId()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Sandwich";
        }
    }
}
