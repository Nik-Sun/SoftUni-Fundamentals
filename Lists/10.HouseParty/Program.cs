using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < number;  i++)
            {
                string[] message = Console.ReadLine()
                    .Split()
                    .ToArray();
                string guestName = message[0];
                if (message.Contains("not"))
                {
                    if (guests.Contains(guestName))
                    {
                        guests.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        guests.Add(guestName);
                    }
                }

            }
            Console.WriteLine(string.Join("\n",guests));
        }
    }
}
