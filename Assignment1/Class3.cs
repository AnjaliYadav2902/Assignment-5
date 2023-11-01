using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class3
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char choice;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            choice = Console.ReadKey().KeyChar;

            
            switch (choice)
            {
                case '1':
                    result = num1 + num2;
                    Console.WriteLine($"Result of Addition: {result}");
                    break;
                case '2':
                    result = num1 - num2;
                    Console.WriteLine($"Result of Subtraction: {result}");
                    break;
                case '3':
                    result = num1 * num2;
                    Console.WriteLine($"Result of Multiplication: {result}");
                    break;
                case '4':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result of Division: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }
        }
    }
}
