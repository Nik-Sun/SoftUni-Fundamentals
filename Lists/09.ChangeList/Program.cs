using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] inputAsArray = input.Split().ToArray();
                string command = inputAsArray[0];
                int element = int.Parse(inputAsArray[1]);
                if (command=="Delete")
                {
                    
                    collection.RemoveAll(x=>x==element);
                }
                if (command=="Insert")
                {
                    int index = int.Parse(inputAsArray[2]);
                    collection.Insert(index, element);

                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",collection));
        }
    }
}
