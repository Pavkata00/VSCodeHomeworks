using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    internal class Store
    {
        public Store(List<int> customers, List<int> suppliers, List<int> orders)
        {
            Customers = customers;
            Suppliers = suppliers;
            Orders = orders;
        }

        public List<int> Customers { get; set; }
        public List<int> Suppliers { get; set; }
        public List<int> Orders { get; set; }


    }
}

