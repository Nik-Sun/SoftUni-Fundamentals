using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine()); 
            for (int i = 1; i <= range; i++)
            {
                int number = i;
                int sum = 0;
                bool isSpecial = false;
                while (number > 0)
                {
                    sum+= number % 10;
                    number /= 10;
                }
                if (sum==5||sum==7||sum==11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
