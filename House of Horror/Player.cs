using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Of_Horror
{
    public class Player
    {
        public string Name { get; set; }
        public Inventory Inventory { get; private set; }

        public Player(string name)
        {
            Name = name;
            Inventory = new Inventory();
        }

        public void ShowInventory()
        {
            Inventory.ShowInventory();
        }
    }
}

