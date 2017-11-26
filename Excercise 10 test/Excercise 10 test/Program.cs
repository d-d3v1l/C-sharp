using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_10_test
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            for (a = 2; a >= 0; a --)
            {
                for (b = 0; b <= 2; b++)
                {
                    if (a == b)
                    {
                        Console.WriteLine(" 1 ");
                    }

                    else
                    {
                        Console.WriteLine(" 0 ");
                    }
                }
            }
        }
    }
}
