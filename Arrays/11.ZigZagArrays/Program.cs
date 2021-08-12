using System;
using System.Linq;

namespace _11.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());
            int[] firstArray = new int[rotations];
            int[] secondArray = new int[rotations];
            for (int i = 0; i < rotations; i++)
            {
                int[] tempArray = new int[2];
                
                tempArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    firstArray[i] = tempArray[0];
                    secondArray[i] = tempArray[1];
                }
                else
                {
                    firstArray[i] = tempArray[1];
                    secondArray[i] = tempArray[0];
                }

            }
            for (int i = 0; i < firstArray.Length*2; i++)
            {
                if (i==firstArray.Length)
                {
                    Console.WriteLine();
                }
                if (i>=firstArray.Length)
                {
                    Console.Write($"{secondArray[i - firstArray.Length]} ");
                }
                else
                {
                    Console.Write(firstArray[i] + " ");
                }
            }
        }
    }
}
