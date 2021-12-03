using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectThree
{


    internal class Program
    {
        static void Main(string[] args)
        {
           
            Bar bar = new Bar();

            List<Thread> studentThreads = new List<Thread>();
            List<Drink> drinks = new List<Drink>();

            Console.WriteLine("Enter starting budget: ");
            int budget = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter drinks count: ");
            int drinkCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < drinkCount; i++)
            {
                Console.WriteLine("Enter name of drink " + (i+1) + ": ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter price: ");
                int price = int.Parse(Console.ReadLine());

                Drink drink = new Drink(name, quantity, price);
                drinks.Add(drink);
            }
            for (int i = 1; i < 100; i++)
            {
                var student = new Student(i.ToString(), bar, drinks, budget, age);
                var thread = new Thread(student.PaintTown);

                thread.Start();
                studentThreads.Add(thread);
            }

            foreach (var t in studentThreads) t.Join();
            Console.WriteLine();
            Console.WriteLine("The party is over.");
            Console.ReadLine();
        }
    }
}
