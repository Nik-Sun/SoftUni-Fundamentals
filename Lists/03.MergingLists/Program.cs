using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            ListMerger(firstList, secondList);
        }

        private static void ListMerger(List<int> firstList, List<int> secondList)
        {
            int longestListCount = firstList.Count > secondList.Count ? firstList.Count : secondList.Count;
            List<int> result = new List<int>();
            for (int i = 0; i < longestListCount; i++)
            {
                if (i >= firstList.Count)
                {
                    result.Add(secondList[i]);
                }
                else if (i >= secondList.Count)
                {
                    result.Add(firstList[i]);
                }
                else
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }


            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
