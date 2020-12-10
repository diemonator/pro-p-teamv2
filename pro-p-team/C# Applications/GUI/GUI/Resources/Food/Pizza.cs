using System;

namespace GUI.Resources.Food
{
    public class Pizza : IProduct
    {
        private int productId;

        public decimal Cost()
        {
            return 7.99m;
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
            return "Pizza";
        }
    }
}
