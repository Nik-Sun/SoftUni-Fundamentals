using System;
using System.Linq;

namespace _16.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                for (int j = array.Length - 1; j > i; j--)
                {
                    sum = array[i] + array[j];
                    if (sum==magicNum)
                    {
                        Console.Write($"{array[i]} {array[j]}");
                        Console.WriteLine();
                    }
                }

            }
        }
    }
}
