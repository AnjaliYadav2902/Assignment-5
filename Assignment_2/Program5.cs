using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program5
    {
        static void Main()
        {
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[] rowSums = new int[rows];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rowSums[i] += matrix[i, j];
                }
            }


            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("Sum of elements in row " + (i + 1) + ": " + rowSums[i]);
            }
        }
    }
}


