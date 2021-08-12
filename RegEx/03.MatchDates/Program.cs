using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<separator>.)(?<month>[A-Z]{1}[a-z]{2})\k<separator>(?<year>\d{4})";
            string input = Console.ReadLine();
            MatchCollection validDates = Regex.Matches(input,pattern);

            foreach (Match date in validDates)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}
