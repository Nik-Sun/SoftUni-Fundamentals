using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"^(?:[>]{2})(?<name>[^<>]+)(?:[<]{2})(?<price>[0-9]+|[\d]+[\.]?[\d]+)!(?<quantity>[\d]+)$";
            List<string> items = new List<string>();
            double sum = 0;
            while (input!= "Purchase")
            {
                items.Add(input);
              
                input = Console.ReadLine();
            }
            MatchCollection validItems = Regex.Matches(string.Join(" ",items), regex);
            Console.WriteLine("Bought furniture:");
            foreach (Match item in validItems)
            {
                string itemName = item.Groups["name"].ToString().Trim();
                double itemPrice = double.Parse(item.Groups["price"].ToString());
                int quantity = int.Parse(item.Groups["quantity"].ToString());
                sum += itemPrice * quantity;
                Console.WriteLine(itemName);
            }
            Console.WriteLine($"Total money spend: {sum :f2}");


          
        }
    }
}
