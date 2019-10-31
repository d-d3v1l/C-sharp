using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_15_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1234, r;
            while (num > 0)
            {
                r = num % 10;
                num = num / 10;
                Console.WriteLine(+r);
            }
        }
    }
}
