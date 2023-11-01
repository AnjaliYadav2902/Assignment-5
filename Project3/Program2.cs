using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program2
    {
        static void Main()
        {
            Console.Write("Input the marks obtained in Physics: ");
            int physicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistryMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics: ");
            int mathMarks = Convert.ToInt32(Console.ReadLine());

            int totalMarks = physicsMarks + chemistryMarks + mathMarks;

            if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (mathMarks + physicsMarks >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }

}




