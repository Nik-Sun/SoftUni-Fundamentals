using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);

        }

        private static void PrintTriangle(int number)
        {
            PrintTriangleUpper(number);
            PrintTriangleBottom(number);
        }

        private static void PrintTriangleBottom(int number)
        {
            for (int i = number - 1; i >= 0; i--)
            {
                PrintSingleLine(i);
            }
        }

        private static void PrintTriangleUpper(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintSingleLine(i);
            }
        }

        static void PrintSingleLine(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
