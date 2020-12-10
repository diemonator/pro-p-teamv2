using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Resources.Decorations
{
    public class Sugar: Decorator
    {
        public Sugar(IProduct p)
        {
            Product = p;
        }
        public override decimal Cost()
        {
            return 1.50m + Product.Cost();
        }

        public override int GetProductId()
        {
            return Product.GetProductId() + 40003;
        }

        public override int ProductCount()
        {
            return Product.ProductCount() - 950;
        }

        public override void ProductId(int id)
        {
            throw new NotImplementedException();
        }

        public override int StoreId()
        {
            return Product.StoreId();
        }
        public override string ToString()
        {
            return Product.ToString() + " with Sugar ";
        }
    }
}
