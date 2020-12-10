using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Resources.Decorations.DrinkDecorations;

namespace GUI
{
    public class OrderUI
    {


        public List<Order> listOfDecoratorsFruits;
        public List<Order> listOfCoffies;
        Order order;
        public OrderUI()
        {
            order = new Order();

            listOfCoffies = new List<Order>();
            listOfDecoratorsFruits = new List<Order>();
        }


    }
}
