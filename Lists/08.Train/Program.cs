using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> trainCars = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split().ToArray(); 

            while (input[0] != "end")
            {
                if (input[0]=="Add")
                {
                    int passangers = int.Parse(input[1]);
                    trainCars.Add(passangers);
                }
                else
                {
                    int passangers = int.Parse(input[0]);
                    AddPassangersToExistingWagon(trainCars, maxCapacity, passangers);
                }

                input = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ",trainCars));
        }




        static void AddPassangersToExistingWagon(List<int> trainCars, int maxCapacity, int passangers)
        {
            for (int i = 0; i < trainCars.Count; i++)
            {
                if (trainCars[i] + passangers <= maxCapacity)
                {
                    trainCars[i] += passangers;
                    break;
                }
            }
        }
    }
}
