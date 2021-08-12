using System;

namespace _16.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int charactersCount = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 0; i < charactersCount; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                int decryptedChar = currentChar.GetHashCode()+key;
                message += (char)decryptedChar;

            }
            Console.WriteLine(message);
        }
    }
}
