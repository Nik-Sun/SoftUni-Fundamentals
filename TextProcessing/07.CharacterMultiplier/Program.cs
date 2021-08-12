using System;

namespace _07.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = MultiplyChars(input[0], input[1]);
            Console.WriteLine(sum);
        }

        static int MultiplyChars(string v1, string v2)
        {
            int sum = 0;
            for (int i = 0; i < Math.Max(v1.Length, v2.Length); i++)
            {
                
                if (i >= v1.Length)
                {
                    sum += v2[i];
                }
                else if (i >= v2.Length)
                {
                    sum += v1[i];
                }
                else
                {
                    sum += v1[i] * v2[i];
                }
            }
            return sum;

        }
    }
}
