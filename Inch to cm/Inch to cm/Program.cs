using System;

public class Program
{
    public static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        double area = a * a;
        Console.Write("Square = ");
        Console.WriteLine(area);
    }
}