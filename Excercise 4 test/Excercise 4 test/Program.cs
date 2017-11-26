// What will be the output of the following Code Snippet?

using System;
class program
{
    static void Main(string[] args)
    {

        int num = 2;
        funl(ref num);
        Console.WriteLine(num);
        Console.ReadLine();
    }

    static void funl(ref int num)

    {
        num = num * num * num;
    }
}

// a.  8   - correct
// b.  0
// c.  2
// d.  16
