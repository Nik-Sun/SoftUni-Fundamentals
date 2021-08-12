using System;
using System.Text;

namespace _11.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            StringBuilder substring = new StringBuilder();
            StringBuilder result = new StringBuilder(text.ToString());
            

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                for (int j = i; j < text.Length; j++)
                {
                    if (text[j]==current)
                    {
                        substring.Append(text[j]);
                       
                        continue;
                    }
                    else
                    {
                       
                        break;
                    }
                }
                result.Replace(substring.ToString(), new string(current, 1));
                substring.Clear();
            }
            Console.WriteLine(result);
            
        }
    }
}
