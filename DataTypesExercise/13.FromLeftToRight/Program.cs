using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _13.FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());


            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string leftNum = string.Empty;
                string rightNum = string.Empty;
                int sum = 0;
                long biggerNum = 0;
                bool isSpaceReached = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == ' ')
                    {
                        isSpaceReached = true;
                    }
                    if (!isSpaceReached)
                    {
                        leftNum += input[j];
                    }
                    else
                    {
                        rightNum += input[j];
                    }

                }
                if (long.Parse(leftNum) > long.Parse(rightNum))
                {
                    biggerNum = long.Parse(leftNum);
                }
                else
                {
                    biggerNum = long.Parse(rightNum);
                }
                for (long k = Math.Abs(biggerNum); k > 0; k /= 10)
                {
                    sum += (int)(k % 10);
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
