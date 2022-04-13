using System;
using System.Linq;

namespace Largest3Numbers
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ')
                                            .Select(x => int.Parse(x))
                                            .OrderByDescending(x => x)
                                            .Take(3);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
