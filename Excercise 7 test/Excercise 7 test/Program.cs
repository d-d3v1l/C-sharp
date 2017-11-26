// 11. What will be the output of the following code snippet?
using System;

class sample

{
    int i;
    double k;
    public sample(int ii, double kk)

    {
        i = ii;
        k = kk;
        double j = (i) - (k);

        Console.WriteLine(j);


}
    ~sample()
{
    double j = i - k;
    Console.WriteLine(j);

}
}

class Program
{

    static void Main(string[] args)
    {
        sample s = new sample(9, 2.5);
    }
}

// a.  0 0
// b.  11 5 0
// c.Compile time error
// d.  11 5 6.5

