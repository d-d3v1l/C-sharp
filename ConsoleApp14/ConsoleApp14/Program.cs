﻿using System;
class program
{
    static void Main(string[] args)
    {

        int x = 4, b = 2;
        x -= b /= x * b;
        Console.WriteLine(x + " " + b);
        Console.ReadLine();
    }
}
