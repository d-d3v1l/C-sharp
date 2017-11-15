using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int jumps = int.Parse(Console.ReadLine());

            var solution = jumps % n;
            Console.WriteLine(solution);
            // kur

        }
    }
}
