using System;
namespace ProrammingEcxercise


{
    class FindOutput
    {

        static void Main(string[] args)

        {
            {
                int i;
                int div = 8, num = 32;

                for (i = 0; i <= 10; i++)
                {
                    if ((num / (div * 3) == 6))

                    {

                        Console.WriteLine(i + " ");
                        continue;
                    }
                    else if (i != 5)

                        Console.WriteLine(i + " ");
                    else
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
    