using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _14.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string regex = @"(?<brd>[|]|#)(?<name>[A-Za-z ]+)\k<brd>(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\k<brd>(?<cal>[0-9]+)\k<brd>";

            MatchCollection matches = Regex.Matches(text,regex);
            List<Item> foods = new List<Item>();
            foreach (Match match in matches)
            {
                Item currentItem = new Item();
                currentItem.Name = match.Groups["name"].Value;
                currentItem.ExpDate = match.Groups["date"].Value;
                currentItem.Calories = int.Parse(match.Groups["cal"].Value);
                foods.Add(currentItem);
            }
            int totalCalories = foods.Select(x => x.Calories).Sum();
            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");
            foreach (Item food in foods)
            {
                Console.WriteLine($"Item: {food.Name}, Best before: {food.ExpDate}, Nutrition: {food.Calories}");
            }
        }
    }
    class Item 
    {
        public string Name { get; set; }
        public string ExpDate { get; set; }
        public int Calories { get; set; }
    }
}
