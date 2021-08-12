using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _11.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(?<ends>[=]|[\/])(?<destination>[A-Z][A-Za-z]{2,})\k<ends>";
            MatchCollection matches = Regex.Matches(input,regex);
            int travelPoints = 0;
            List<string> destinations = new List<string>();
            foreach (Match item in matches)
            {
                destinations.Add(item.Groups["destination"].Value);
                travelPoints += item.Groups["destination"].Value.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ",destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
