using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(?<separator>[@|#])(?<word1>[A-Z|a-z]{3,})\k<separator>{2}(?<word2>[A-Z|a-z]+)\k<separator>";
            MatchCollection matches = Regex.Matches(input,regex);
            List<string> pairs = new List<string>();
            foreach (Match pair in matches)
            {
                string firstWord = pair.Groups["word1"].Value;
                string secondWord = pair.Groups["word2"].Value;
                string secondWordReversed = string.Join("", secondWord.Reverse());
                if (firstWord==secondWordReversed)
                {
                    pairs.Add($"{firstWord} <=> {secondWord}");
                }
                
            }
            if (matches.Count>0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                if (pairs.Count > 0)
                {
                    Console.WriteLine($"The mirror words are:\n{string.Join(", ", pairs)}");
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!\nNo mirror words!");
            }
           
           
        }

        
    }
}
