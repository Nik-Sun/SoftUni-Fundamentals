using System;

namespace _21.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTopNumbersFromOneTo(input);
        }

        static void PrintTopNumbersFromOneTo(int input)
        {
            for (int i = 1; i <=input; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int input)
        {
            int sum = 0;
            bool haveOddDigit = false;
            bool isTopNumber = false;
            while (input>0)
            {
                int currentDigit = 0;
                currentDigit += input % 10;
                if (currentDigit%2!=0)
                {
                    haveOddDigit = true;
                }
                sum += currentDigit;
                input /= 10;
            }
            if (sum%8==0&&haveOddDigit)
            {
                isTopNumber = true;
            }
            return isTopNumber;
        }
    }
}
