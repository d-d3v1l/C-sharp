using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            string Monday = "monday";
            string tuesday = "tuesday";
            string wednesday = "wednesday";
            string thursday = "thursday";
            string friday = "friday";
            string saturday = "saturday";
            string sunday = "sunday";

            string apple = "apple";
            string banana = "banana";
            string grapes = "grapes";
            string orange = "orange";
            string grapefruit = "grapefruit";
            string kiwi = "kiwi";
            string pinapple = "pinapple";

            double price = -1.0;

            if (dayOfWeek == Monday ||
                dayOfWeek == tuesday ||
                dayOfWeek == wednesday ||
                dayOfWeek == thursday ||
                dayOfWeek == friday)
            {
                if (product == apple)
                {
                    price = 1.2;
                }
                else if (product == banana)
                {
                    price = 2.5;
                }
                else if (product == orange)
                {
                    price = 0.85;
                }

                else if (product == grapefruit)
                {
                    price = 1.45;
                }

                else if (product == kiwi)
                {
                    price = 2.7;
                }

                else if (product == pinapple)
                {
                    price = 5.5;
                }

                else if (product == grapes)
                {
                    price = 3.85;
                }
            }

            else if (dayOfWeek == saturday || dayOfWeek == sunday)

            {
                if (product == apple)
                {
                    price = 1.25;
                }
                else if (product == banana)
                {
                    price = 2.7;
                }
                else if (product == orange)
                {
                    price = 0.90;
                }

                else if (product == grapefruit)
                {
                    price = 1.60;
                }

                else if (product == kiwi)
                {
                    price = 3.0;
                }

                else if (product == pinapple)
                {
                    price = 5.6;
                }

                else if (product == grapes)
                {
                    price = 4.20;
                }
            }

            if (price < 0)
            {
                Console.WriteLine("Error");
            }

            double result = price * quantity;
            Console.WriteLine($"{result:f2}");
        }

    }

}


