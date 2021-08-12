using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int productQuantity = int.Parse(Console.ReadLine());

            TotalPrice(product,productQuantity);
        }
                                                

        static void TotalPrice(string product, int productQuantity)
        {
            double result = 0;
            switch (product)
            {
                case "coffee":
                    result = productQuantity * 1.5;
                    break;
                case "water":
                    result = productQuantity * 1.0;
                    break;
                case "coke":
                    result = productQuantity * 1.40;
                    break;
                case "snacks":
                    result = productQuantity * 2;
                    break;
            }
            Console.WriteLine($"{result :f2}");
        }
    }
}
