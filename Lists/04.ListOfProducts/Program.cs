using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int itemsCount = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < itemsCount; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i = 0; i < itemsCount; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
          
        }
    }
}
