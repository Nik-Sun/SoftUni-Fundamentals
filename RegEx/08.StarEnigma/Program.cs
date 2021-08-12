using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int messagesCount = int.Parse(Console.ReadLine());
            List<string> atkPlanets = new List<string>();
            List<string> destrPlanets = new List<string>();
            for (int i = 0; i < messagesCount; i++)
            {
                StringBuilder message = new StringBuilder(Console.ReadLine());
                string regexForKey = "[starSTAR]";
                MatchCollection letters = Regex.Matches(message.ToString(), regexForKey);
                int key = letters.Count;
                for (int j = 0; j < message.Length; j++)
                {
                    message[j] -= (char)key;
                }
                string regexForMessage = @"[^:@\-!:>]*@(?<name>[A-Za-z]+)[^:@\-!:>]*:(?<pops>[0-9]+)!(?<type>[AD])![^:@\-!:>]*->(?<soldiers>[0-9]+)[^:@\-!:>]*$";

                Match currentInfo = Regex.Match(message.ToString(), regexForMessage);
                if (currentInfo.Success)
                {
                    string planetName = currentInfo.Groups["name"].ToString();
                    string atkType = currentInfo.Groups["type"].ToString();
                    if (atkType == "D")
                    {
                        destrPlanets.Add(planetName);
                    }
                    else
                    {
                        atkPlanets.Add(planetName);
                    }
                }


            }
            atkPlanets.Sort();
            destrPlanets.Sort();
            Console.WriteLine($"Attacked planets: {atkPlanets.Count}");
            foreach (var item in atkPlanets)
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destrPlanets.Count}");
            foreach (var item in destrPlanets)
            {
                Console.WriteLine($"-> {item}");
            }
          
            
        }
    }
}
