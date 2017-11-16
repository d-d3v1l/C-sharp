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
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            string sofiaTown = "Sofia";
            string plovdivTown = "Plovdiv";
            string varnaTown = "Plovdiv";

            bool isSmallerThan500 = sales >= 0 && sales <= 500;
            bool isSmallerThan1000 = sales > 500 && sales <= 1000;
            bool isSmallerThan10000 = sales > 1000 && sales <= 10000;
            bool biggerThan10000 = sales > 10000;

            double comission = -1.0;

            if (town == sofiaTown)
            {
                if (isSmallerThan500)
                {
                    comission = 0.05;
                }

                else if (isSmallerThan1000)
                {
                    comission = 0.07;
                }
                else if (isSmallerThan10000)
                {
                    comission = 0.08;
                }
                else if (biggerThan10000)
                {
                    comission = 0.12;
                }

            }

            else if (town == plovdivTown)
            {
                if (isSmallerThan500)
                {
                    comission = 0.055;
                }

                else if (isSmallerThan1000)
                {
                    comission = 0.08;
                }
                else if (isSmallerThan10000)
                {
                    comission = 0.12;
                }
                else if (biggerThan10000)
                {
                    comission = 0.145;
                }
            }
            else if (town == varnaTown)
            {
                if (isSmallerThan500)
                {
                    comission = 0.045;
                }

                else if (isSmallerThan1000)
                {
                    comission = 0.075;
                }
                else if (isSmallerThan10000)
                {
                    comission = 0.1;
                }
                else if (biggerThan10000)
                {
                    comission = 0.13;
                }
            }

            if (comission < 0.0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                double result = sales * comission;
                Console.WriteLine(result.ToString("f2"));
            }

        }

    }

}


