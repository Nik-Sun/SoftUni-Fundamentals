using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;  
            for (int i = 1; i <=num*2; i++)
            {
                if (i%2==0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    result += i;
                }
            }
            Console.WriteLine($"Sum: {result}");
        }
    }
}
