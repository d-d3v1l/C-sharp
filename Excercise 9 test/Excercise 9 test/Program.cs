using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_9_test
{
    class FindOutput
    {
        static void Main(string[] args)
        {

            int i = 30;
            int j = 5 % 5;

            if (Convert.ToBoolean(Convert.ToInt32(i != j)))
            {
                Console.WriteLine("If Clause executed");
            }
            
            else
            {
                Console.WriteLine("Else Clause executed");
             }
            Console.WriteLine("Entered Main Function");
            Console.ReadLine();


        }
    }
}

// a.If clause executed
// b.Else clause executed
// c.If clause executed
// Entered Main Function
// d.Else clause executed
// Entered Main Function
