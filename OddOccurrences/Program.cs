using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().Split();
            var occurrencies = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (occurrencies.ContainsKey(word)) occurrencies[word]++;
                else occurrencies[word] = 1;
            }

            var result = occurrencies.Where(x => x.Value % 2 != 0)
                                     .Select(x => x.Key)
                                     .ToList();
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
