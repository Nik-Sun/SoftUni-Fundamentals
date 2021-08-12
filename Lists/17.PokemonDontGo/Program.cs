using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int score = 0;
            while (pokemons.Count>0)
            {//5 10 6 3 5
                int currentPokemon = 0;
                int index = int.Parse(Console.ReadLine());
                if (index<0)
                {
                    currentPokemon = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                   
                }
                else if (index>pokemons.Count-1)
                {
                    currentPokemon = pokemons[pokemons.Count-1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    
                }
                else
                {
                    currentPokemon = pokemons[index];
                    pokemons.RemoveAt(index);
                }
               
                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i]<=currentPokemon)
                    {
                        pokemons[i] += currentPokemon;
                    }
                    else if (pokemons[i]>currentPokemon)
                    {
                        pokemons[i] -= currentPokemon;
                    }
                }

                score += currentPokemon;
            }
            Console.WriteLine(score);

        }
    }
}
