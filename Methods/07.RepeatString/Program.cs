using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            string repeatedString=RepeatString(text,num);
            Console.WriteLine(repeatedString);
        }

        static string RepeatString(string text, int num)
        {
            string result = string.Empty;
            for (int i = 0; i < num; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
