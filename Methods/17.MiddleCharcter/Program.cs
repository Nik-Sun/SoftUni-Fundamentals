using System;

namespace _17.MiddleCharcter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MidChar(input);
        }

        static void MidChar(string input)
        {
            char midChar=input[(input.Length /2)-1] ;
            char nextChar = input[(input.Length / 2)];
            if (input.Length%2==0)
            {
                Console.WriteLine($"{midChar}{nextChar}");
            }
            else
            {
                Console.WriteLine(nextChar);
            }
        }
    }
}
