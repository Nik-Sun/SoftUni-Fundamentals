using System;
using System.Linq;
using System.Text;

namespace _07.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "Reveal")
            {
                string[] instructions = input.Split(":|:");
                string command = instructions[0];
                if (command == "InsertSpace")
                {
                    int index = int.Parse(instructions[1]);
                    message.Insert(index," ");
                }
                else if (command =="Reverse")
                {
                    string substring = instructions[1];
                    if (message.ToString().Contains(substring))
                    {
                        int index = message.ToString().IndexOf(substring);
                        string reversedSubstring = string.Join("",substring.ToArray().Reverse());
                        message.Remove(index,substring.Length);
                        message.Append(reversedSubstring);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        input = Console.ReadLine();
                        continue;
                    }
                   
                }
                else if (command== "ChangeAll")
                {
                    string substring = instructions[1];
                    string replacement = instructions[2];
                    message.Replace(substring,replacement);
                }
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
