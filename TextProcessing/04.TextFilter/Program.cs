using System;
using System.Text;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] censuredWords = Console.ReadLine().Split(", ");
            StringBuilder text = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < censuredWords.Length; i++)
            {
                text.Replace(censuredWords[i], new string('*', censuredWords[i].Length));
            }
            Console.WriteLine(text);



        }
    }
}
