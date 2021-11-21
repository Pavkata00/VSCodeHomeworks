using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of buyers please... " + "(Max amount - 100)");
            int buyers = int.Parse(Console.ReadLine());
            List<int> listOfBuyers = new List<int>();

            CheckForLimitAndAdd(buyers, 100, listOfBuyers);

            Console.WriteLine("Enter number of suppliers please... " + "(Max amount - 5)");
            List<int> suppliersList = new List<int>();
            int suppliers = int.Parse(Console.ReadLine());

            CheckForLimitAndAdd(suppliers, 5, suppliersList);
           

            Console.WriteLine("Enter number of orders please... " + "(Max amount - 20)");
            List<int> ordersList = new List<int>();
            int orders = int.Parse(Console.ReadLine());


            CheckForLimitAndAdd(orders, 20, ordersList);
          

            Store store = new Store(listOfBuyers, suppliersList, ordersList);

            Console.WriteLine("Number of buyers - " + string.Join(" ", store.Customers.Max()));
            Console.WriteLine("Number of suppliers - " + string.Join(" ", store.Suppliers.Max()));
            Console.WriteLine("Number of orders - " + string.Join(" ", store.Orders).Max());
        }

        private static void CheckForLimitAndAdd(int number,int limit, List<int> list)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i == limit)
                {
                    Console.WriteLine("You reached the maximum amount allowed!");
                    break;
                }

                list.Add(i);
            }
        }
    }
}