using System;
using System.Linq;

namespace _14.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;
            int inDex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = i-1; j >=0; j--)
                {
                     leftSum += array[j];
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];     
                }
                if (leftSum==rightSum)
                {
                    isFound = true;
                    inDex = i;
                    break;
                }
   
            }
            if (isFound)
            {
                Console.WriteLine(inDex);
            }
            else
            {
                Console.WriteLine("no");
            }
            

        }
    }
}
