using System;

public class Program
{
    public static void Main()
    {
        double C = double.Parse(Console.ReadLine());
        var farenheit = C * 1.8 + 32;
        Console.WriteLine("Celsius to farenheit = " + farenheit);

    }
}