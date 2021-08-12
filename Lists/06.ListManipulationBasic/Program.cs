using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                int commandParameters = int.Parse(command[1]);
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(commandParameters);
                        break;

                    case "Remove":
                        numbers.Remove(commandParameters);
                        break;

                    case "RemoveAt":
                        numbers.RemoveAt(commandParameters);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(command[2]);
                        numbers.Insert(numberToInsert, commandParameters);
                        break;

                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
