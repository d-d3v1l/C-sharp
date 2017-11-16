using System;

namespace _14.Currency_Converter
{
    class Currency_Converter
    {
        static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var first = Console.ReadLine().ToLower();
            var second = Console.ReadLine().ToLower();

            if (first == "bgn")
            {
                if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.79549, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num / 1.95583, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405, 2));
                }
            }

            if (first == "usd")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.79549, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round((num * 1.79549) / 1.95583, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round((num * 1.79549) / 2.53405, 2));
                }
            }

            if (first == "eur")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.95583, 2));
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round((num * 1.95583) / 1.79549, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round((num * 1.95583) / 2.53405, 2));
                }
            }

            if (first == "gbp")
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405, 2));
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round((num * 2.53405) / 1.79549, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round((num * 2.53405) / 1.95583, 2));
                }
        }
    }
}