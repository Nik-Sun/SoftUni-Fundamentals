using System;

namespace _07.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int winsCount = 0;
            bool ranOutOfEnergy = false;
            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                int distance = int.Parse(input);
                initialEnergy -= distance;
                if (initialEnergy>=0)
                {
                    winsCount++;
                }
                else if (initialEnergy<0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winsCount} won battles and {initialEnergy+distance} energy");
                    ranOutOfEnergy = true;
                    break;
                }
                if (winsCount%3==0)
                {
                    initialEnergy += winsCount;
                }

                input = Console.ReadLine();
            }
            if (!ranOutOfEnergy)
            {
                Console.WriteLine($"Won battles: {winsCount}. Energy left: {initialEnergy}");
            }


        }
    }
}
