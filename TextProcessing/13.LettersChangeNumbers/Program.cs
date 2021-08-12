using System;
using System.Text;

namespace _13.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                
                char firstLetter = currentWord[0];
                char lastLetter = currentWord[currentWord.Length - 1];
                StringBuilder number = new StringBuilder(currentWord.Substring(1, currentWord.Length - 2).ToString());
                double currentNum = double.Parse(number.ToString());
                if (char.IsUpper(firstLetter))
                {
                    currentNum = currentNum / (firstLetter - 64);
                }
                else
                {
                    currentNum = currentNum * (firstLetter - 96);
                }
                if (char.IsUpper(lastLetter))
                {
                    currentNum -= lastLetter - 64;
                }
                else
                {
                    currentNum += lastLetter - 96;
                }
                sum += currentNum;
            }
            Console.WriteLine($"{sum :f2}");
        }
    }
}
