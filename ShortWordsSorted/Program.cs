using System;
using System.Linq;

namespace ShortWordsSorted
{
    internal class Program
    {
        static void Main()
        {
            var words = Console.ReadLine()
                               .ToLower()
                               .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Where(a => a.Length < 5)
                               .OrderBy(a => a)
                               .Distinct();

            Console.WriteLine(String.Join(", ", words));
        }
    }
}

