using System;
using System.Collections.Generic;

namespace _07.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string resource = string.Empty;
            int quantity = 0;
            Dictionary<string, int> resources = new Dictionary<string, int>();
            for (int i = 1; i != 0; i++)
            {
                if (input == "stop")
                {
                    break;
                }
                else if (i % 2 == 0)
                {
                    quantity = int.Parse(input);

                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += quantity;
                    }
                    else
                    {
                        resources.Add(resource, quantity);
                    }
                }
                else
                {
                    resource = input;
                   
                }
               

                input = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
