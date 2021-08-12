using System;
using System.Linq;

namespace _15.MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int temp = 0;
            int sequenceLength = 1;
            int longestSequence = 0;
            int numberInSequence = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i==0)
                {
                    temp = array[i];
                    continue;
                }
                if (temp==array[i])
                {
                    sequenceLength++;
                    if (sequenceLength>longestSequence)
                    {
                        numberInSequence = temp;
                        longestSequence = sequenceLength;
                    }
 
                }
                else
                {
                    temp = array[i];
                    sequenceLength = 1;
                }
               
            }
            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write(numberInSequence + " ");
            }
        }
    }
}
