using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Product> orders = new Dictionary<string,Product>();

            while (input != "buy")
            {
                string[] inputAsArray = input.Split();
                Product currentProduct = new Product();
                string currentProductName = inputAsArray[0];
                currentProduct.Price = double.Parse(inputAsArray[1]);
                currentProduct.Quantity = int.Parse(inputAsArray[2]);

                if (orders.ContainsKey(currentProductName))
                {
                    orders[currentProductName].Quantity += currentProduct.Quantity;
                    if (currentProduct.Price!=orders[currentProductName].Price)
                    {
                        orders[currentProductName].Price = currentProduct.Price;
                    }
                }
                else
                {
                    orders.Add(currentProductName, currentProduct);
                }
               
                input = Console.ReadLine();

            }

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Price * item.Value.Quantity :f2}");
            }
        }
        public class Product
        {
            public int Quantity { get; set; }
            public double Price { get; set; }

        }
    }
}
