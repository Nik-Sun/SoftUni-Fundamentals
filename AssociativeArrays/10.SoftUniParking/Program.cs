using System;
using System.Collections.Generic;

namespace _10.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> usersAndPlates = new Dictionary<string, string>();
            for (int i = 0; i < commandsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string userName = input[1];
                if (command== "register")
                {
                    string plateNumber = input[2];
                    if (usersAndPlates.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {usersAndPlates[userName]}");
                    }
                    else
                    {
                        usersAndPlates.Add(userName, plateNumber);
                        Console.WriteLine($"{userName} registered {plateNumber} successfully");
                    }

                }
                else if (command == "unregister")
                {
                    if (!usersAndPlates.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        usersAndPlates.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }

            foreach (var item in usersAndPlates)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
