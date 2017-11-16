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

            for (int currentRow = 0; currentRow < 10; currentRow++)
            {
                for (int currentCol = 0; currentCol < 10; currentCol++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
