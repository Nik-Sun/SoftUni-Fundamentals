using System;

namespace _12.SmallestInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int[] numbers = new int[] { num1, num2, num3 };

            int result =SmallestIntegerFromArray(numbers);
            Console.WriteLine(result);

        }

        static int SmallestIntegerFromArray(int[] numbers)
        {
            int result = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<result)
                {
                    result = numbers[i];
                }
            }
            return result;
        }
    }
}
