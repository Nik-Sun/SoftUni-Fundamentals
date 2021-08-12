using System;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split("|");
            int health = 100;
            int bitcoins = 0;
            bool isDead = false;
            for (int i = 0; i < rooms.Length; i++)
            {
                if (isDead)
                {
                    break;
                }
                string[] currentRoom = rooms[i].Split();
                string roomType = currentRoom[0];
                int number = int.Parse(currentRoom[1]);
                switch (roomType)
                {
                    case "potion":
                        if (number+health>100)
                        {
                            int healedAmount = (health + number)-100;
                            Console.WriteLine($"You healed for {number-healedAmount} hp.");
                            health += number - healedAmount;
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {number} hp.");
                            health += number;
                            Console.WriteLine($"Current health: {health} hp.");
                        }

                        break;
                    case "chest":
                        Console.WriteLine($"You found {number} bitcoins.");
                        bitcoins += number;
                        break;
                    default:
                        if (health - number<=0)
                        {
                            Console.WriteLine($"You died! Killed by {roomType}.");
                            Console.WriteLine($"Best room: { i+1}");
                            isDead = true;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {roomType}.");
                            health -= number;
                        }
                        break;
                }
            }
            if (!isDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: { bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
