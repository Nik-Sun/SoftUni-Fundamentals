using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.SoftuniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> orders = new List<string>();
            while (input !="end of shift")
            {
                orders.Add(input);

                input = Console.ReadLine();
            }
            string regex = @"%(?<name>[A-Z][a-z]+)%[^&|%\.]*<(?<product>[\w]+)>[^&|%\.]*\|(?<quantity>[0-9]+)[^&|%\.]*\|[^&|%\.\d]*(?<price>[\d]+\.?[0-9]*)\$";

            MatchCollection matches = Regex.Matches(string.Join(Environment.NewLine,orders),regex);
            double sum = 0;
            List<string> validOrders = new List<string>();
            foreach (Match item in matches)
            {
                string name = item.Groups["name"].ToString();
                string product = item.Groups["product"].ToString();
                string totalPrice = $"{double.Parse(item.Groups["price"].ToString()) * int.Parse(item.Groups["quantity"].ToString()) :f2}";
                sum += double.Parse(totalPrice);
                validOrders.Add($"{name}: {product} - {totalPrice}");
            }
            Console.WriteLine(string.Join("\n",validOrders));
            Console.WriteLine($"Total income: {sum :f2}");
        }
    }
}
