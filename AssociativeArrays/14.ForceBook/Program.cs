using System;
using System.Collections.Generic;

namespace _14.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isUserFirst = false;
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                string[] data = input.Split(" | ");
                if (data.Length<2)
                {
                    isUserFirst = true;
                    data = input.Split(" -> ");
                }
                else
                {
                    isUserFirst = false;
                }
                if (!isUserFirst)
                {
                   
                    if (forceBook.ContainsKey(data[0]))
                    {
                        if (!forceBook[data[0]].Contains(data[1]))
                        {
                            forceBook[data[0]].Add(data[1]);
                        }
                    }
                    else
                    {
                        forceBook.Add(data[0],new List<string> {data[1]});
                    }
                    
                }
                else
                {
                    if (forceBook[data[1]].Contains(data[0]))
                    {
                        forceBook[data[1]].
                    }
                }

                
                input = Console.ReadLine();
            }
        }
    }
   
}
