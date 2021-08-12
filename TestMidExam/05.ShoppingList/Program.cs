using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!")
                .ToList();
            string input = Console.ReadLine();
            while (input!= "Go Shopping!")
            {
                string[] command = input.Split();
                string action = command[0];
                string item = command[1];
                switch (action)
                {
                    case "Urgent":
                        if (!shoppingList.Contains(item))
                        {
                            shoppingList.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        if (shoppingList.Contains(item))
                        {
                            shoppingList.Remove(item);
                        }
                        break;
                    case "Correct":
                      
                        string newItem = command[2];
                        if (shoppingList.Contains(item))
                        {
                            int oldItemIndex = shoppingList.FindIndex(x => x == item);
                            shoppingList[oldItemIndex] = newItem;
                        }
                        break;
                    case "Rearrange":
                        if (shoppingList.Contains(item))
                        {
                            shoppingList.Remove(item);
                            shoppingList.Add(item);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",shoppingList));
        }
    }
}
