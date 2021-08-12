using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte linesCount = byte.Parse(Console.ReadLine());
            byte tank = 0;

            for (int i = 0; i < linesCount; i++)
            {
                short liters = short.Parse(Console.ReadLine());
                if (tank+liters>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tank += (byte)liters;
                }
            }
            Console.WriteLine(tank);
        }
    }
}
