using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());
            for (int i = 0; i <numberOfLetters; i++)
            {
                for (int j = 0; j < numberOfLetters; j++)
                {
                    for (int k = 0; k < numberOfLetters; k++)
                    {
                        Console.WriteLine($"{char.ConvertFromUtf32(i+97)}{char.ConvertFromUtf32(j + 97)}{char.ConvertFromUtf32(k + 97)}");
                    }
                }
            }
        }
    }
}
