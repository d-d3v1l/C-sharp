using System;

public class Program
{
    public static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double p = r * 2 * Math.PI;
        double s = r * r * Math.PI;
        Console.WriteLine(s);
        Console.WriteLine(p);

    }
}