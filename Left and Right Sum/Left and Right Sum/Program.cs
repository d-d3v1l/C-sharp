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
            int maxRotations = numbersToRead * 2;

            int leftSum = 0;

            for (int i = 0; i < numbersToRead; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                leftSum += currentNumber;
            }
            int rightSum = 0;
            for (int i = 0; i < numbersToRead; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                rightSum += currentNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }

            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}





