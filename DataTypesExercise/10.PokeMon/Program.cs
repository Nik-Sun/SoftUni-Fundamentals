using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            uint InitialPokePower = uint.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetsPoked = 0;
            uint currentPokePower = InitialPokePower;
            while (currentPokePower>=distance)
            {
                currentPokePower -= (uint)distance;
                targetsPoked++;
                if ((currentPokePower==(double)InitialPokePower/2)&&exhaustionFactor!=0)
                {
                    currentPokePower /= (uint)exhaustionFactor;
                }
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}
