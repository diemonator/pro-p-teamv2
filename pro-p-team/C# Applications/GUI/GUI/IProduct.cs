using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public interface IProduct
    {
        decimal Cost();

        string ToString();

        void ProductId(int id);

        int GetProductId();

        int StoreId();

        int ProductCount();
    }
}
