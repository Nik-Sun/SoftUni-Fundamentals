using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result=GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }



        static int GetSumOfEvenDigits(int number) 
        {
            int sum = 0;
            while (number>0)
            {
                int currentDigit = number % 10;
                if (currentDigit%2==0)
                {
                    sum += currentDigit;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int a) 
        {
            int result = GetSumOfEvenDigits(a) * GetSumOfOddDigits(a);
            return result;
        }


    }
}
