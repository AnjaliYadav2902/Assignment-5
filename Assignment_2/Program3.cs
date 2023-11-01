using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program3
    {
        static void Main()
        {

            int[] numbers = { 5, 10, 3, 20, 8, 15 };


            int max = numbers[0];


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }


            Console.WriteLine("The maximum element in the array is: " + max);
        }
    }

}



