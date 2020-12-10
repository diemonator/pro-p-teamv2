using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public abstract class Decorator : IProduct
    {
        public IProduct Product { get; set; }

        public abstract decimal Cost();
        public abstract int GetProductId();
        public abstract int ProductCount();
        public abstract void ProductId(int id);
        public abstract int StoreId();

    }
}
