using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleInfo = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
            List<Person> clients = new List<Person>();
            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] currentPerson = peopleInfo[i].Split("=",StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(currentPerson[0], double.Parse(currentPerson[1]));
                clients.Add(person);
            }
            string[] productsInfo = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();
            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] currentProduct = productsInfo[i].Split("=",StringSplitOptions.RemoveEmptyEntries);
                Product product = new Product(currentProduct[0],double.Parse(currentProduct[1]));
                products.Add(product);
            }
            string[] shoppingInfo = Console.ReadLine().Split();
            while (shoppingInfo[0] != "END")
            {
                int clientIndex = clients.FindIndex(x => x.Name == shoppingInfo[0]);
                int productIndex = products.FindIndex(x => x.Name == shoppingInfo[1]);
                clients[clientIndex].Buy(products[productIndex]);
                shoppingInfo = Console.ReadLine().Split();

            }
            foreach (Person item in clients)
            {
                Console.WriteLine($"{item.Name} - {(item.Bag.Count ==0 ? "Nothing bought" : string.Join(", ",item.Bag.Select(x => x.Name)))}");
            }
        }
    }
    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Bag = new List<Product>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Bag { get; set; }
        public void Buy(Product product)
        {
            if (Money >= product.Price)
            {
                Console.WriteLine($"{Name} bought {product.Name}");
                Bag.Add(product);
                Money -= product.Price;
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
    }
    class Product
    {
        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
