using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_14_test
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            i = 0;

            while (i++ < 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");

            i = 0;
            while (++i < 5)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
// a.  1 2 3 4
// 1 2 3 4 5
// b.  1 2 3
// 1 2 3 4
// c.  1 2 3 4 5
// 1 2 3 4
// d.  1 2 3 4 5
// 1 2 3 4 5
