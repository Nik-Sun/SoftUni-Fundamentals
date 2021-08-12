using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string toPrint = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                toPrint += symbol;
            }
            Console.WriteLine(toPrint);
        }
    }
}
