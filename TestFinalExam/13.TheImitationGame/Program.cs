using System;
using System.Text;

namespace _13.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder encryptedMessage = new StringBuilder(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] commandInfo = input.Split("|");
                string command = commandInfo[0];
                if (command == "Move")
                {
                    int symbolsCount = int.Parse(commandInfo[1]);
                    string substring = encryptedMessage.ToString().Substring(0, symbolsCount);
                    encryptedMessage.Remove(0, substring.Length);
                    encryptedMessage.Append(substring);

                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandInfo[1]);
                    string value = commandInfo[2];

                    encryptedMessage.Insert(index, value);

                }
                else if (command == "ChangeAll")
                {
                    string substring = commandInfo[1];
                    string replacement = commandInfo[2];
                    encryptedMessage.Replace(substring, replacement);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
