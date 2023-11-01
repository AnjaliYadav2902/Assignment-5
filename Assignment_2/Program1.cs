using System;

namespace Assignment_2
{
    internal class Program1
    {
        static void Main()
        {

            int[] numbers = { 1, 2, 3, 4, 5 };

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }


            double average = (double)sum / numbers.Length;


            Console.WriteLine("Sum of elements: " + sum);
            Console.WriteLine("Average of elements: " + average);
        }
    }
}
