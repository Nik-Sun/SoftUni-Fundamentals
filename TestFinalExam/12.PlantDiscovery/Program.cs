using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int plantsCount = int.Parse(Console.ReadLine());
            List<Plant> collection = new List<Plant>();
            for (int i = 0; i < plantsCount; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");
                string plantName = plantInfo[0];
                int plantRarity = int.Parse(plantInfo[1]);
               
                if (collection.Exists(x=> x.Name==plantName))
                {
                    int index = collection.FindIndex(x=>x.Name==plantName);
                    collection[index].Rarity = plantRarity;
                }
                else
                {
                    Plant currentPlant = new Plant();
                    currentPlant.Name = plantName;
                    currentPlant.Rarity = plantRarity;
                    currentPlant.Ratings = new List<double>();
                    collection.Add(currentPlant);
                }

            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                char[] splitter = {':','-' };
                string[] commandData = input.Split(splitter).Select(x=>x.Trim()).ToArray();
                string command = commandData[0];
                string plantName = commandData[1];
                int index = collection.FindIndex(x=>x.Name==plantName);
                if (index == -1)
                {
                    Console.WriteLine("error");
                    input = Console.ReadLine();
                    continue;
                }
                if (command== "Rate")
                {
                    double rating = double.Parse(commandData[2]);
                    collection[index].Ratings.Add(rating);
                }
                else if (command == "Update")
                {
                    int newRarity = int.Parse(commandData[2]);
                    collection[index].Rarity = newRarity;
                }
                else if (command == "Reset")
                {
                    collection[index].Ratings.Clear();
                   
                }
                else
                {
                    Console.WriteLine("error");
                }


                input = Console.ReadLine();
            }
            collection = collection.OrderByDescending(x => x.Rarity).ThenByDescending(x => x.Ratings.Sum() / x.Ratings.Count).ToList();
            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant item in collection)
            {
                if (item.Ratings.Count==0)
                {
                    item.Ratings.Add(0);
                }
                Console.WriteLine($"- {item.Name}; Rarity: {item.Rarity}; Rating: {(item.Ratings.Sum() / item.Ratings.Count) :f2}");
            }
        }
    }
    class Plant 
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<double> Ratings { get; set; }
    }
}
