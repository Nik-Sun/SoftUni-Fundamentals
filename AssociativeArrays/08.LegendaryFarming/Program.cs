using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, Dictionary<string, int>> items = new Dictionary<string, Dictionary<string, int>>();
            items.Add("legendaries", new Dictionary<string, int>());
            items["legendaries"].Add("shards", 0);
            items["legendaries"].Add("fragments", 0);
            items["legendaries"].Add("motes", 0);
            items.Add("junk", new Dictionary<string, int>());
            bool flag = false;


            for (int i = 1; i != 0; i++)
            {
                int quantity = 0;
                string item = string.Empty;

                for (int j = 0; j < input.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        quantity = int.Parse(input[j]);
                    }
                    else
                    {
                        item = input[j].ToLower();
                        if (item == "motes")
                        {
                            items["legendaries"]["motes"] += quantity;
                        }
                        else if (item == "shards")
                        {
                            items["legendaries"]["shards"] += quantity;
                        }
                        else if (item == "fragments")
                        {
                            items["legendaries"]["fragments"] += quantity;
                        }
                        else
                        {
                            if (items["junk"].ContainsKey(item))
                            {
                                items["junk"][item] += quantity;
                            }
                            else
                            {
                                items["junk"].Add(item, quantity);
                            }

                        }
                        bool isDragonwrathObtained = items["legendaries"]["motes"] >= 250;
                        bool isShadowmourneObtained = items["legendaries"]["shards"] >= 250;
                        bool isValanyrObtained = items["legendaries"]["fragments"] >= 250;
                        if (isDragonwrathObtained)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            items["legendaries"]["motes"] -= 250;
                            flag = true;
                            break;
                        }
                        else if (isShadowmourneObtained)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            items["legendaries"]["shards"] -= 250;
                            flag = true;
                            break;
                        }
                        else if (isValanyrObtained)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            items["legendaries"]["fragments"] -= 250;
                            flag = true;
                            break;
                        }
                    }


                }

                if (flag)
                {
                    break;
                }

                input = Console.ReadLine().Split();

            }
            
            items["legendaries"] = items["legendaries"].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in items["legendaries"])
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            items["junk"] = items["junk"].OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in items["junk"])
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
