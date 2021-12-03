using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectThree
{
    class Student
    {
        private int age;
        enum NightActivities { Walk, VisitTheBar, GoHome };
        enum BarActivities { Drink, Dance, Leave };

        Random random = new Random();

        public string Name { get; set; }
        public Bar Bar { get; set; }
        public List<Drink> Drink { get; set; }
        public int Budget { get; set; }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("The Bar doesn't let in people below 18");
                }
                else
                {
                    age = value;
                }
            }

        }

        public Student(string name, Bar bar, List<Drink> drinks, int budget, int age)
        {
            Name = name;
            Bar = bar;
            Drink = drinks;
            Budget = budget;
            Age = age;
        }
        //Random activities
        private NightActivities GetRandomNightlifeActivity()
        {
            int n = random.Next(10);

            if (n < 3) return NightActivities.Walk;
            if (n < 8) return NightActivities.VisitTheBar;

            return NightActivities.GoHome;
        }

        private BarActivities GetRandomBarActivity()
        {
            int n = random.Next(10);

            if (n < 4) return BarActivities.Dance;
            if (n < 9) return BarActivities.Drink;

            return BarActivities.Leave;
        }

        private void WalkOut()
        {
            Console.WriteLine($"{Name} is walking in the streets.");
            Thread.Sleep(100);
        }

        private void VisitBar()
        {
            Console.WriteLine($"{Name} is getting in the line to enter the bar.");
            Bar.Enter(this);

            Console.WriteLine($"{Name} entered the bar!");
            bool staysAtBar = true;

            while (staysAtBar)
            {
                var nextActivity = GetRandomBarActivity();
                switch (nextActivity)
                {
                    case BarActivities.Dance:
                        Console.WriteLine($"{Name} is now dancing.");
                        Thread.Sleep(100);
                        break;
                    case BarActivities.Drink:
                        Console.WriteLine($"{Name} is now drinking.");
                        Thread.Sleep(100);
                        break;
                    case BarActivities.Leave:
                        Console.WriteLine($"{Name} is now leaving the bar.");
                        Bar.Leave(this);

                        staysAtBar = false;
                        break;
                    default: throw new NotImplementedException();
                }
            }
        }

        public void PaintTown()
        {
            WalkOut();
            bool staysOut = true;
            while (staysOut)
            {
                var nextActivity = GetRandomNightlifeActivity();
                switch (nextActivity)
                {
                    case NightActivities.Walk:
                        WalkOut();
                        break;
                    case NightActivities.VisitTheBar:
                        VisitBar();
                        staysOut = false;
                        break;
                    case NightActivities.GoHome:
                        staysOut = false;
                        break;
                    default: throw new NotImplementedException();
                }
            }
            Console.WriteLine($"{Name} is going back home.");
        }

        
    }
}
