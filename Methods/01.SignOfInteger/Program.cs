using System;

namespace _01.SignOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SignOfInteger(n);
        }

         static void SignOfInteger(int n)
         { 
            if (n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n==0)
            {
                Console.WriteLine($"The number 0 is zero.");
            }
            else
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            
         }
    }
}
