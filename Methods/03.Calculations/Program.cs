using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (command == "add")
            {
                Add(x, y);
            }
            else if (command == "multiply")
            {
                Multiply(x, y);
            }
            else if (command == "subtract")
            {
                Subtract(x, y);
            }
            else if (command == "divide")
            {
                Divide(x,y);
            }
        }

        private static void Divide(int x,int y)
        {
            int result = x / y;
            Console.WriteLine(result);
        }

        private static void Subtract(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }

        static void Multiply(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        static void Add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }
    }
}
