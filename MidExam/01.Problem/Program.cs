using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int workerProductionPerDay = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int competingFactoruOutput = int.Parse(Console.ReadLine());

            int biscuitsPerGoodDay = workerProductionPerDay * countOfWorkers;
            int biscuitsPerBadDay = (int)Math.Floor((workerProductionPerDay * countOfWorkers) * 0.75);
            int totalBiscuits = (biscuitsPerGoodDay*20) + biscuitsPerBadDay*10;


            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
            double difference = 0;

            if (totalBiscuits > competingFactoruOutput)
            {
                difference = totalBiscuits - competingFactoruOutput;
                Console.WriteLine($"You produce {difference / competingFactoruOutput * 100:f2} percent more biscuits.");

            }
            else
            {
                difference = competingFactoruOutput - totalBiscuits;
                Console.WriteLine($"You produce {difference / competingFactoruOutput * 100:f2} percent less biscuits.");
            }

        }
    }
}
