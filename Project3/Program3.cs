using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program3
    {
        static void Main()
        {
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter the number of units consumed: ");
            int unitsConsumed = int.Parse(Console.ReadLine());

            double chargePerUnit;

            if (unitsConsumed <= 199)
            {
                chargePerUnit = 1.20;
            }
            else if (unitsConsumed >= 200 && unitsConsumed < 400)
            {
                chargePerUnit = 1.50;
            }
            else if (unitsConsumed >= 400 && unitsConsumed < 600)
            {
                chargePerUnit = 1.80;
            }
            else
            {
                chargePerUnit = 2.00;
            }

            double totalAmount = unitsConsumed * chargePerUnit;
            double surcharge = 0;

            if (totalAmount > 400)
            {
                surcharge = 0.15 * totalAmount;
            }

            if (totalAmount < 100)
            {
                totalAmount = 100;
            }

            double netAmount = totalAmount + surcharge;

            Console.WriteLine("Customer IDNO: " + customerId);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Unit Consumed: " + unitsConsumed);
            Console.WriteLine("Amount Charges @Rs. " + chargePerUnit + " per unit: " + totalAmount.ToString("F2"));
            Console.WriteLine("Surcharge Amount: " + surcharge.ToString("F2"));
            Console.WriteLine("Net Amount Paid By the Customer: " + netAmount.ToString("F2"));
        }
    }

}




