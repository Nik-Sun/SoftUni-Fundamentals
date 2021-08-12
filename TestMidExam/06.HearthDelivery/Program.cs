using System;
using System.Linq;

namespace _06.HearthDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhood = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            int cupidPosition = 0;
            while (input != "Love!")
            {
                string[] command = input.Split();
                
                int jumpLength = int.Parse(command[1]);
                if (jumpLength+cupidPosition>=neighbourhood.Length)
                {
                    cupidPosition = 0;
                    neighbourhood[cupidPosition] -= 2;
                }
                else
                {
                    neighbourhood[cupidPosition + jumpLength] -= 2;
                    cupidPosition += jumpLength;
                }
                if (neighbourhood[cupidPosition]==0)
                {
                    Console.WriteLine($"Place {cupidPosition} has Valentine's day.");
                }
                else if (neighbourhood[cupidPosition]<0)
                {
                    Console.WriteLine($"Place {cupidPosition} already had Valentine's day."); 
                }
                input = Console.ReadLine();
            }
            int counter = 0;
            for (int i = 0; i < neighbourhood.Length; i++)
            {
                if (neighbourhood[i]<=0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Cupid's last position was {cupidPosition}.");
            if (counter==neighbourhood.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                
                Console.WriteLine($"Cupid has failed {neighbourhood.Length - counter} places.");
            }
        }
    }
}
