using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<string> reversedWords = new List<string>();
            while (word.ToString()!="end")
            {
                reversedWords.Add(word);

                word = Console.ReadLine();
            }
            foreach (var item in reversedWords)
            {
                Console.WriteLine($"{item} = {Reverse(item)}");
            }
        }

        static string Reverse(string word)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = word.Length-1; i >=0; i--)
            {
                temp.Append(word[i]);
            }
            return temp.ToString();
        }
    }
}
