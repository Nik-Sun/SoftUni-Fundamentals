using System;

namespace _02.PrintNumbersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            int[] numbers = new int[iterations];
            for (int i = 0; i < iterations; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            for (int i = iterations-1; i >=0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
