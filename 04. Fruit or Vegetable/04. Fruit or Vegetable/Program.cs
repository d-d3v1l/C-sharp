using System;

public class Program
{
    public static void Main()
    {

        string food = Console.ReadLine().ToLower();

        bool isFruit = food == "banana" ||
            food == "apple" ||
            food == "kiwi" ||
            food == "cherry" ||
             food == "lemon" ||
            food == "grapes";

        bool isVegetable = food == "cucumber" || food == "carrot" || food == "pepper" || food == "tomato";

        if (isFruit)
        { Console.WriteLine("Fruit"); }

        else if (isVegetable)
        { Console.WriteLine("Vegetable"); }

        else
        { Console.WriteLine("Unknown"); }
    }


}
