using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(",").Select(x => x.Trim()).ToArray();
         
            string regexHP = @"[^0-9\+\-\*\/\.\,]";
            string regexDmg = @"[\-\+]?[0-9]+\.?[0-9]*";
           
            List<string> demons = new List<string>();
            for (int i = 0; i < data.Length; i++)
            {
                
                string name = data[i];
                string[] healthData = Regex.Matches(data[i], regexHP).Cast<Match>().Select(x => x.Value).ToArray();
                int health = healthData.Select(x => x.Select(ch => (int)ch)).Select(x => x.Sum()).Sum();
                string[] dmgData = Regex.Matches(data[i], regexDmg).Select(x => x.ToString()).ToArray();
                double damage = dmgData.Select(double.Parse).Sum();
                
                foreach (char item in name)
                {
                    if (item == '*')
                    {
                        damage *= 2;
                    }
                    else if (item =='/')
                    {
                        damage /= 2;
                    }
                }
                demons.Add($"{name} - {health} health, {damage :f2} damage");
            }
            demons.Sort();
            Console.WriteLine(string.Join("\n",demons));
        }
    }
}
