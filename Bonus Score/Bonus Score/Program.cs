using System;

public class Program
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());

        double bonus = 0;

        if (a <= 100)
        {
            bonus = 5;
        }

        else if (a <= 1000)
        {
            bonus = a * 0.20;
        }

        else if (a > 1000)
        {
            bonus = a * 0.10;
        }

        if (a % 2 == 0)
        {
            bonus = bonus + 1;
        }

        else if (a % 10 == 5)
        {
            bonus = bonus + 2;
        }
        Console.WriteLine(bonus);
        Console.WriteLine(a + bonus);

    }

}
