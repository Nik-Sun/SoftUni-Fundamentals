﻿using System;

namespace _05.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            for (int i = startIndex; i <=endIndex; i++)
            {
                Console.Write(char.ConvertFromUtf32(i));
                Console.Write(' ');
            }
        }
    }
}