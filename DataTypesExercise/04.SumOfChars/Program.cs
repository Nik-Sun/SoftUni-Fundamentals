using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            int sumOfChars = 0;
            for (int i = 0; i < interval; i++)
            {
                char current = char.Parse(Console.ReadLine());
                sumOfChars += current;

            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
