using System;
using System.Text;

namespace _09.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < text.Length; i++)
            {
                text[i] += (char)3;
            }
            Console.WriteLine(text);
        }
    }
}
