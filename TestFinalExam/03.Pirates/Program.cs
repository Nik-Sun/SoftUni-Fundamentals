using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {

            List<City> cities = new List<City>();
            string input = Console.ReadLine();
            while (input != "Sail")
            {
                City currentCity = new City();
                string[] cityInfo = input.Split("||");
                string name = cityInfo[0];
                int population = int.Parse(cityInfo[1]);
                int gold = int.Parse(cityInfo[2]);
                
               
                if (cities.Any(x=>x.Name==name))
                {
                    int index = cities.FindIndex(x=>x.Name==name);
                    cities[index].Gold += gold;
                    cities[index].Population += population;
                       
                }
                else
                {
                    currentCity.Name = name;
                    currentCity.Population = population;
                    currentCity.Gold = gold;
                    cities.Add(currentCity);
                }
               
                input = Console.ReadLine();
            }
            string action = Console.ReadLine();
            while (action != "End")
            {
                string[] scenario = action.Split("=>");
                string act = scenario[0];
                if (act == "Plunder")
                {
                    string town = scenario[1];
                    int people = int.Parse(scenario[2]);
                    int gold = int.Parse(scenario[3]);
                    string cityToRemove = string.Empty;
                    foreach (City city in cities)
                    {
                        if (city.Name == town)
                        {
                            city.Population -= people;
                            city.Gold -= gold;
                            Console.WriteLine($"{city.Name} plundered! {gold} gold stolen, {people} citizens killed.");
                        }
                        if (city.Population == 0 || city.Gold == 0)
                        {
                            Console.WriteLine($"{city.Name} has been wiped off the map!");
                            cityToRemove = city.Name;
                        }
                    }
                    cities.RemoveAll(x=>x.Name==cityToRemove);

                }
                else if (act == "Prosper")
                {
                    string town = scenario[1];
                    int gold = int.Parse(scenario[2]);
                    if (gold > 0)
                    {
                        foreach (City city in cities)
                        {
                            if (city.Name == town)
                            {
                                city.Gold += gold;
                                Console.WriteLine($"{gold} gold added to the city treasury. {city.Name} now has {city.Gold} gold.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }

                action = Console.ReadLine();
            }
            if (cities.Count > 0)
            {
                cities = cities.OrderByDescending(x => x.Gold).ThenBy(x => x.Name).ToList();
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (City city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}   
    class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }

