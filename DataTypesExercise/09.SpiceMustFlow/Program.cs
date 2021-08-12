using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYieldOfSource = int.Parse(Console.ReadLine());
            int currentYield = startingYieldOfSource;
            int spiceMined = 0;
            int daysOperated = 0;
            while (currentYield>=100)
            {
                spiceMined += currentYield - 26;
                currentYield -= 10;
                daysOperated++;
            }
            if (spiceMined-26<0)
            {
                spiceMined = 0;
            }
            else
            {
                spiceMined -= 26;
            }
            Console.WriteLine(daysOperated);
            Console.WriteLine(spiceMined);
        }
    }
}
