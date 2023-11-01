using System;

namespace Assignment1
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;

            if (num2 != 0)
            {
                double quotient = num1 / num2;
                Console.WriteLine($"Quotient: {quotient}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
