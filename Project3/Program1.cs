using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program1
    {
        static void Main()
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5, 6 };

           
            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            
            foreach (int num in arr)
            {
                if (elementCount.ContainsKey(num))
                {
                    elementCount[num]++;
                }
                else
                {
                    elementCount[num] = 1;
                }
            }

           
            int totalDuplicateCount = 0;
            foreach (var pair in elementCount)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine($"Element {pair.Key} has {pair.Value} duplicates.");
                    totalDuplicateCount += pair.Value - 1;
                }
            }

            Console.WriteLine($"Total number of duplicate elements: {totalDuplicateCount}");
        }
    }

}



