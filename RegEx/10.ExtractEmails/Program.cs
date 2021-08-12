using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string regex = @"\b([a-zA-Z0-9+._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]{2,})";

            MatchCollection extracted = Regex.Matches(text, regex);
            List<string> emails = extracted.Select(x => x.Value).ToList();
            Console.WriteLine(string.Join("\n",emails));
        }
    }
}
