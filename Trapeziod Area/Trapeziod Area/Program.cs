using System;

public class Program
{
    public static void Main()
    {
        double b1 = double.Parse(Console.ReadLine());
        double a1 = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        var area = (a1 + b1) * h / 2;
        Console.WriteLine("Trapec area = " + area);

    }
}