﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Tea : IProduct
    {
        private int productId;
        public decimal Cost()
        {
            return 1.49m;
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
            return "Tea";
        }
    }
}