﻿using System;

public class Program
{
    public static void Main()
    {
        string password = Console.ReadLine();

        string a = "s3cr3t!P@ssw0rd";

        if (password == a) { Console.WriteLine("Welcome"); }

        else { Console.WriteLine("Wrong password!"); }

    }


}
