using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class7
    {
        static void Main()
        {
            Console.Write("Enter a number to display its table: ");
            int number = int.Parse(Console.ReadLine());

            // Using a for loop
            Console.WriteLine("Table of " + number + " using for loop:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            // Using a while loop
            int j = 1;
            Console.WriteLine("\nTable of " + number + " using while loop:");
            while (j <= 10)
            {
                Console.WriteLine($"{number} x {j} = {number * j}");
                j++;
            }

            // Using a do-while loop
            int k = 1;
            Console.WriteLine("\nTable of " + number + " using do-while loop:");
            do
            {
                Console.WriteLine($"{number} x {k} = {number * k}");
                k++;
            } while (k <= 10);
        }
    }
}


