using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program2
    {
        static void Main()
        {
            int[,] matrix1 = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int[,] matrix2 = {
                {9, 8, 7},
                {6, 5, 4},
                {3, 2, 1}
            };

            int[,] sumMatrix = new int[3, 3];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }


            Console.WriteLine("Sum of the matrices:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
