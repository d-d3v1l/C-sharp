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
            int numbersToRead = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            for (int i = 0; i < numbersToRead; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                Console.WriteLine(maxNumber);
            }
        }
    }
}





