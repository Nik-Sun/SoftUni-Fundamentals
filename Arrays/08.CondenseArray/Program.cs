using System;
using System.Linq;

namespace _08.CondenseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToCondense = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            while (arrayToCondense.Length>1)
            {
                int[] condensedArray = new int[arrayToCondense.Length - 1];
                for (int i = 0; i < arrayToCondense.Length-1; i++)
                {
                    condensedArray[i] = arrayToCondense[i] + arrayToCondense[i+1];
                }
                arrayToCondense = condensedArray;

            }
            Console.WriteLine(arrayToCondense[0]);

            
            
            
        }
    }
}
