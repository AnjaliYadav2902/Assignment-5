using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class5
    {
        static void Main()
        {
            // Using do-while loop
            Console.WriteLine("Using do-while loop:");
            int num = 2;
            do
            {
                Console.WriteLine(num);
                num += 2;
            } while (num <= 20);

            // Using while loop
            Console.WriteLine("\nUsing while loop:");
            num = 2;
            while (num <= 20)
            {
                Console.WriteLine(num);
                num += 2;
            }

            // Using for loop
            Console.WriteLine("\nUsing for loop:");
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}






