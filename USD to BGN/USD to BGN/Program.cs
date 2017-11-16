using System;

public class Program
{
    public static void Main()
    {
        double BGN = double.Parse(Console.ReadLine());
        var USD = Math.Round(BGN * 1.7955, 3);
        Console.WriteLine(" BGN to USD = " + USD);

    }
}