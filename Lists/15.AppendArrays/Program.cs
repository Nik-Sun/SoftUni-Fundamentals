using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string temp = string.Empty;
            for (int i = 0; i < input.Count; i++)
            {
                temp += input[input.Count - 1 - i]+" ";   
            }
            int[] output = temp.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
