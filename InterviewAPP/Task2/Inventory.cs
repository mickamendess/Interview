using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Inventory
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string ReadInventory()
        {
            using (StreamReader r = new StreamReader("../../../Products.json"))
            {
                return r.ReadToEnd();
            }
        }

        public void SortInventory(string Json, bool Ascending, string SortKey)
        {
            //Json to Object
            var Obj = JsonConvert.DeserializeObject<List<Inventory>>(Json);
            IOrderedEnumerable<Inventory> SortedObj;
            //Getting Property to use as Key
            var Property = typeof(Inventory).GetProperty(SortKey);
            SortedObj = Obj.OrderBy(x => Property.GetValue(x, null));
            //Object to Formatted Json
            string JsonFormatted = JsonConvert.SerializeObject(SortedObj, Formatting.Indented);
            Console.WriteLine(JsonFormatted);
        }
    }
}
