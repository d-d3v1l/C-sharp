using System;

public class Program
{
    public static void Main()
    {
        string word = Console.ReadLine();
        string word1 = Console.ReadLine();

        word = word.ToLower();
        word1 = word1.ToLower();

        if (word.Equals(word1)) { Console.WriteLine("yes"); }

        else { Console.WriteLine("no"); }


    }


}
