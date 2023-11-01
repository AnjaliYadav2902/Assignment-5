using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program4
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

            int[] columnSums = new int[cols];


            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    columnSums[j] += matrix[i, j];
                }
            }


            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine("Sum of elements in column " + (j + 1) + ": " + columnSums[j]);
            }
        }
    }
}





