using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection fullNames = Regex.Matches(names,pattern);
            foreach (Match item in fullNames)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
