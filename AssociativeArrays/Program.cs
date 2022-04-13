using System;
using System.Collections.Generic;

namespace AssociativeArrays
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ');
            var counts = new SortedDictionary<decimal, int>();

            foreach (var num in numbers)
            {
                decimal parsedNum = decimal.Parse(num);
                if (counts.ContainsKey(parsedNum)) counts[parsedNum]++;
                else counts[parsedNum] = 1;
            }

            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
