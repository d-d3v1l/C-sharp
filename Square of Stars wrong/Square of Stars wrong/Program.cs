using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int currentRow = 1; currentRow < size; currentRow++)
            {
                for (int currentCol = 0; currentCol < currentRow; currentCol++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();

            }
        }
    }
}
