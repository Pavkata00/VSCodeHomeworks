using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    class Drink
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Drink(string name, int quantity, int price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
