using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "Craft!")
            {
                string[] command = input.Split(" - ");
                string action = command[0];
                string item = command[1];
                if (action== "Collect")
                {
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                }
                else if (action == "Drop")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }
                else if (action == "Combine Items")
                {
                    string[] itemsToCombine = item.Split(":");
                    string oldItem = itemsToCombine[0];
                    string newItem = itemsToCombine[1];
                    int indexOfOldItem = 0;
                    if (inventory.Contains(oldItem))
                    {
                        indexOfOldItem=inventory.FindIndex(x=>x==oldItem);
                        if (indexOfOldItem+1>=inventory.Count)
                        {
                            inventory.Add(newItem);
                        }
                        else
                        {
                            inventory.Insert(indexOfOldItem + 1, newItem);
                        }
                    }
                }
                else if (action== "Renew")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",inventory));         
        }
    }
}
