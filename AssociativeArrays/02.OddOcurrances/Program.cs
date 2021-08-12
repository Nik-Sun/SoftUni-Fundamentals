using System;
using System.Collections.Generic;

namespace _02.OddOcurrances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> wordsAndOccurances = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                currentWord = currentWord.ToLower();
                if (wordsAndOccurances.ContainsKey(currentWord))
                {
                    wordsAndOccurances[currentWord]++;
                }
                else
                {
                    wordsAndOccurances.Add(currentWord, 1);
                }
            }

            foreach (var item in wordsAndOccurances)
            {
                if (item.Value%2!=0)
                {
                    Console.Write(item.Key + " ");
                }
            }


        }
    }
}
