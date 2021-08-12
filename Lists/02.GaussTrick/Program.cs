using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string sum = string.Empty;
            while (numbers.Count>1)
            {
                sum += numbers[0] + numbers[numbers.Count - 1] + " ";
                numbers.RemoveAt(0);
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine($"{sum.Trim()} {string.Join(" ",numbers)}");
        }
    }
}
