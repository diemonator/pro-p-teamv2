using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSDappProP
{
    class Item : ITech
    {
        //fields
        private int id;
        private string description;
        private double price;
        private int amount;

        //properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        //constructors
        public Item(int id, string description, double price, int amount)
        {
            Id = id;
            Description = description;
            Price = price;
            Amount = amount;
        }
            
        //methods
        public double Cost()
        {
            return Price;
        }

        public int GetId()
        {
            return Id;
        }

        public void TechCount()
        {
            throw new NotImplementedException();
        }

        public void TechId(int i)
        {
            throw new NotImplementedException();
        }

        public string TechName()
        {
            return description;
        }

        public override string ToString()
        {
            return "Name: " + this.Description + ", Price: " + this.Price;
        }
    }
}
