using System;
using System.Text;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder rawKey = new StringBuilder(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] command = input.Split(">>>");
                string operation = command[0];
                if (operation== "Contains")
                {
                    string substring = command[1];
                    if (rawKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (operation=="Flip")
                {
                    string flipType = command[1];
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    string substring = rawKey.ToString().Substring(startIndex,(endIndex-startIndex));
                    if (flipType=="Upper")
                    {
                        substring = substring.ToUpper();
                    }
                    else
                    {
                        substring = substring.ToLower();
                    }
                    rawKey.Remove(startIndex,(endIndex-startIndex));
                    rawKey.Insert(startIndex,substring);
                    Console.WriteLine(rawKey);
                }
                else if (operation == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    rawKey.Remove(startIndex,(endIndex-startIndex));
                    Console.WriteLine(rawKey);
                }
                

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
