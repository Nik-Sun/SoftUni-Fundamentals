using System;
using System.Collections.Generic;

namespace _06.CharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> charsAndCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar==' ')
                {
                    continue;
                }
                else if (charsAndCount.ContainsKey(currentChar))
                {
                    charsAndCount[currentChar]++;
                }
                else
                {
                    charsAndCount.Add(currentChar,1);   
                }
            }
            foreach (var item in charsAndCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
