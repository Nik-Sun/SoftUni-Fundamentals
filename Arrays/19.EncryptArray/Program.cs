using System;

namespace _19.EncryptArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysCount = int.Parse(Console.ReadLine());
            int[] resultArray = new int[arraysCount];
            for (int i = 0; i < arraysCount; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {

                    if ("AEIOUaeiou".Contains(input[j]))
                    {
                        sum += input[j] * input.Length;
                    }
                    else
                    {
                        sum += input[j] / input.Length;
                    }

                }
                resultArray[i] = sum;
            }

            int[] sortedArray = new int[resultArray.Length];
            for (int i = sortedArray.Length-1; i >=0 ; i--)
            {
                int indexOfBiggest = 0;
                for (int j = 0; j < resultArray.Length; j++)
                {
                    if (sortedArray[i] < resultArray[j])
                    {
                        sortedArray[i] = resultArray[j];
                        indexOfBiggest = j;
                    }
                }
                resultArray[indexOfBiggest] = 0;
            }

            Console.WriteLine(string.Join("\n",sortedArray));

        }
    }
}
