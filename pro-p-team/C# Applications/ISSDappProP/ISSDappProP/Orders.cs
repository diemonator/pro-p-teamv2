using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSDappProP
{
    class Order
    {
        //fields
        private readonly List<ITech> items = null;
        private int id;
        private int quantity;

        //constructors
        public Order()
        {
            items = new List<ITech>();
        }

        //properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        //Methods
        public double total()
        {
            double temp = 0;
            for (int i = 0; i < items.Count; i++)
            {
                temp += items[i].Cost();
            }
            return temp;
        }
        public int Lenght()
        {
            return items.Count();
        }
        public void AddToList(ITech item)
        {
            items.Add(item);
        }

        public void RemoveFromList(ITech item)
        {
            foreach (ITech i in items)
            {
                if (i.GetId() == item.GetId())
                {
                    items.Remove(i);
                }
            }
        }

        public List<ITech> getItems()
        {
            return this.items;
        }
    }
}
