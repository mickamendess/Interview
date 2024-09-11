using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Inventory Inventory = new Inventory();
            dynamic InventoryArray = Inventory.ReadInventory();
            //Insert the following parameters to change the Sort Order and Key
            Inventory.SortInventory(InventoryArray, true, "Name");
        }
    }
}
