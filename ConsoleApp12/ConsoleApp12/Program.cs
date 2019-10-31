using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
              
        static void Main(string[] args)
        {
            {
                int[,] matrix =
      {
{1, 2, 3, 4}, // row 0 values
{5, 6, 7, 8}, // row 1 values
};
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();

                }
    }
}
