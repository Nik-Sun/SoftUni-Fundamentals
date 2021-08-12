using System;

namespace _16.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            
            int result = Subtract(Sum(num1,num2),num3);
            Console.WriteLine(result);
        }

        private static int Subtract(int v, int num3)
        {
            int result = v - num3;
            return result;
        }

        static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
    }
}
