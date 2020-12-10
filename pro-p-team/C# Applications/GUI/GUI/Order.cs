using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Order
    {
        public List<IProduct> products;


        public Order()
        {
            products = new List<IProduct>();
        }

        public void Add(IProduct item)
        {
            products.Add(item);

        }
        public IProduct First()
        {
            return products[0];

        }
        public int[] Quantity()
        {
            var sorted = products.OrderBy(x => x.ToString());
            IProduct[] temphold = sorted.ToArray();

            short index = 0;
            int[] qProduct = new int[temphold.Distinct().ToArray().Length];
            short counter = 0;
            try
            {

                for (int i = 0; i < temphold.Length; i++)
                {
                    if (i == 0)
                    {
                        counter++;
                        qProduct[index] = counter;                                             
                    }

                    else if (temphold[i].ToString() == temphold[i - 1].ToString())
                    {
                        counter++;
                    }
                    else
                    {
                        counter++;
                        qProduct[index] = counter;
                        counter = 0;
                        index++;
                    }

                }
                counter++;
                qProduct[index] = counter;
                counter = 0;
                index++;                
                return qProduct;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return qProduct;
        }


        public IProduct Last()
        {
            return products[products.Count - 1];

        }
        public object[] Details()
        {
            return products.ToArray();
        }
        public override string ToString()
        {
            return First().ToString() + " - " + Last().Cost() + " - " + Last().GetProductId();
        }
    }
}
