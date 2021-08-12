using System;
using System.Text;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            StringBuilder line = new StringBuilder(Console.ReadLine());
            int startIndex = line.ToString().IndexOf(wordToRemove);
            while (startIndex>=0)
            {
               
                line.Remove(startIndex, wordToRemove.Length);
                startIndex = line.ToString().IndexOf(wordToRemove);

            }
            Console.WriteLine(line);
        }
    }
}
