using System;

public class Program
{
    public static void Main()
    {

        Console.WriteLine(DateTime.Today.AddSeconds(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine())).ToString("m:ss"));

    }


}
