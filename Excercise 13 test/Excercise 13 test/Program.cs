using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_13_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            if (Convert.ToBoolean(Convert.ToInt32(++a)) || Convert.ToBoolean(Convert.ToInt32(++b)))
            {
                Console.WriteLine(a + "\n" + b);
            
            }
            else
            Console.WriteLine("C# questions");
	{

            }
        }
    }
}
// a.  12
// b.  22
// c.  23
// d.  24
