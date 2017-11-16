using System;

public class Program
{
    public static void Main()
    {
        double rad = double.Parse(Console.ReadLine());
        var deg = Math.Round((rad * 57.29578), 0);
        Console.WriteLine(" Radial to degrees = " + deg);

    }
}