using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();
            for (int i = 0; i < heroesCount; i++)
            {
                string[] heroData = Console.ReadLine().Split();
                Hero currentHero = new Hero();
                currentHero.Name = heroData[0];
                currentHero.Health = int.Parse(heroData[1]);
                currentHero.Mana = int.Parse(heroData[2]);
                heroes.Add(currentHero);

            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] actionData = input.Split(" - ");
                string action = actionData[0];
                string name = actionData[1];
                int heroIndex = heroes.FindIndex(x => x.Name == name);
                if (action == "CastSpell")
                {
                    
                    int manaNeeded = int.Parse(actionData[2]);
                    string spellName = actionData[3];
                    if (heroes[heroIndex].Mana >= manaNeeded)
                    {
                        heroes[heroIndex].Mana -= manaNeeded;
                        Console.WriteLine($"{heroes[heroIndex].Name} has successfully cast {spellName} and now has {heroes[heroIndex].Mana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroes[heroIndex].Name} does not have enough MP to cast {spellName}!");
                    }   

                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(actionData[2]);
                    string attacker = actionData[3];
                    heroes[heroIndex].Health -= damage;
                    if (heroes[heroIndex].Health<=0)
                    {
                        Console.WriteLine($"{heroes[heroIndex].Name} has been killed by {attacker}!");
                        heroes.Remove(heroes[heroIndex]);
                    }
                    else
                    {
                        Console.WriteLine($"{heroes[heroIndex].Name} was hit for {damage} HP by {attacker} and now has {heroes[heroIndex].Health} HP left!");
                    }
                }
                else if (action == "Recharge")
                {
                    int mana = int.Parse(actionData[2]);
                    heroes[heroIndex].Mana += mana;
                    int manaRecovered = 0;
                    if (heroes[heroIndex].Mana>200)
                    {
                        manaRecovered = mana - (heroes[heroIndex].Mana - 200);
                        heroes[heroIndex].Mana = 200;
                    }
                    else
                    {
                        manaRecovered = mana;
                    }
                    Console.WriteLine($"{heroes[heroIndex].Name} recharged for {manaRecovered} MP!");
                }
                else if (action == "Heal")
                {
                    int healing = int.Parse(actionData[2]);
                    int healthRecovered = 0;
                    heroes[heroIndex].Health += healing;
                    if (heroes[heroIndex].Health>100)
                    {
                        healthRecovered = healing - (heroes[heroIndex].Health - 100);
                        heroes[heroIndex].Health = 100;
                    }
                    else
                    {
                        healthRecovered = healing;
                    }
                    Console.WriteLine($"{heroes[heroIndex].Name} healed for {healthRecovered} HP!");
                }

                input = Console.ReadLine();

            }
            heroes = heroes.OrderByDescending(x => x.Health).ThenBy(x => x.Name).ToList();
            foreach (Hero item in heroes)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine($"  HP: {item.Health}");
                Console.WriteLine($"  MP: {item.Mana}");
            }
        }
        class Hero 
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int Mana { get; set; }
            
        }
    }
}
