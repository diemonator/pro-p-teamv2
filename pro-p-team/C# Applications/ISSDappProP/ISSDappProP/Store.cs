using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSDappProP
{
    class Store
    {
        private List<ITech> inventory;

        public Store()
        {
            inventory = new List<ITech>();
            inventory.Add(new Item(13, "Phone Charger", 12.50 , 50));
            inventory.Add(new Item(14, "Laptop Charger", 15.00, 50));
            inventory.Add(new Item(15, "Batteries", 5.00, 50));
            inventory.Add(new Item(16, "Phone", 30.00, 50));
            inventory.Add(new Item(17, "Laptop", 60.00, 50));
            inventory.Add(new Item(18, "Camera", 45.00, 50));
            inventory.Add(new Item(19, "Speakers", 30.00, 50));
            inventory.Add(new Item(20, "Headphone", 25.00, 50));
            inventory.Add(new Item(21, "RFID", 5.00, 50));
            inventory.Add(new Item(22, "Monitor", 25.00, 50));
            inventory.Add(new Item(23, "Microphone", 25.00, 50));
        }

        public List<ITech> GetInventory()
        {
            return inventory;
        }
    }
}
