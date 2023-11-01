using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class6
    {
        static void Main(string[] args)
        {
            // Using do-while loop
            Console.WriteLine("Using do-while loop:");
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 20);

            // Using while loop
            Console.WriteLine("\nUsing while loop:");
            i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i += 2;
            }

            // Using for loop
            Console.WriteLine("\nUsing for loop:");
            for (i = 1; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}





