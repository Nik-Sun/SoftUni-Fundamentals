using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"[+][3][5][9](?<seperator>[ ,-])[2]\k<seperator>[0-9]{3}\k<seperator>[0-9]{4}\b";

            string input = Console.ReadLine();
            MatchCollection phoneNumbers = Regex.Matches(input,regex);

            Console.WriteLine(string.Join(", ",phoneNumbers));
        }
    }
}
