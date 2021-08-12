using System;
using System.Linq;

namespace _04.LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] sortedNumbers = numbers.OrderByDescending(x => x).ToArray();
            int n = sortedNumbers.Length >= 3 ? 3 : numbers.Length;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{sortedNumbers[i]} ");
            }
              
            
        }
    }
}
