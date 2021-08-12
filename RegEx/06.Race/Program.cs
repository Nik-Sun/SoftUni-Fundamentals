using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> rankings = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input!= "end of race")
            {
                string namePattern = @"([a-zA-Z])+";
                string numberPattern = @"([0-9])";
                MatchCollection letters = Regex.Matches(input,namePattern);
                MatchCollection numbers = Regex.Matches(input,numberPattern);
                string name = string.Join("", letters);
                int score = 0;
                foreach (Match item in numbers)
                {
                    score += int.Parse(item.Value.ToString());
                }
                if (participants.Contains(name))
                {
                    if (rankings.ContainsKey(name))
                    {
                        rankings[name] += score;
                    }
                    else
                    {
                        rankings.Add(name, score);
                    }
                }
                input = Console.ReadLine();
            }
            rankings = rankings.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
            Console.WriteLine($"1st place: {rankings.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {rankings.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {rankings.ElementAt(2).Key}");
        }
    }
}
