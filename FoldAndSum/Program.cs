using System;
using System.Linq;

namespace FoldAndSum
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ');
            var k = numbers.Length / 4;
            var firstRow = numbers.Take(k).Reverse().Concat(numbers.Skip(3 * k).Reverse()).Select(int.Parse);
            var secondRow = numbers.Skip(k).Take(2 * k).Select(int.Parse).ToArray();
            var sum = firstRow.Select((x, i) => x + secondRow[i]).ToArray();

            Console.WriteLine(String.Join(" ", sum));

        }
    }
}
