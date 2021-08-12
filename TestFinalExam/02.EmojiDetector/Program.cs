using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string coolTresholdRegex = @"[0-9]";
            string emojyRegex = @"(?<emojy>(?<separator>[:]{2}|[*]{2})(?<body>[A-Z][a-z]{2,})\k<separator>)";
            MatchCollection digits = Regex.Matches(text,coolTresholdRegex);
            BigInteger coolTreshold = 1;
            foreach (Match digit in digits)
            {
                coolTreshold *= int.Parse(digit.Value.ToString());
            }
            List<string> emojys = new List<string>();
            MatchCollection foundEmojys = Regex.Matches(text,emojyRegex);
            foreach (Match item in foundEmojys)
            {
                
                emojys.Add(item.Groups["emojy"].ToString());
            }
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{emojys.Count} emojis found in the text. The cool ones are:");
            for (int i = 0; i < emojys.Count; i++)
            {
                int sum = 0;
                for (int j = 0; j < emojys[i].Length; j++)
                {
                    if (char.IsLetter(emojys[i][j]))
                    {
                        sum += emojys[i][j];
                    }
                }
                if (sum>coolTreshold)
                {
                    Console.WriteLine(emojys[i]);
                }
            }
        }
    }
}
