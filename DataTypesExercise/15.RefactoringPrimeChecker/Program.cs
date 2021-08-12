using System;

namespace _15.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int num = 2; num <=range; num++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}
