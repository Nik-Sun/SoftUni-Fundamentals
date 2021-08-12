using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> genres = Console.ReadLine()
                .Split(" | ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input!="Stop!")
            {
                string[] command = input.Split();
                string genre = command[1];
                if (command[0] == "Join")
                {
                    
                    if (!genres.Contains(genre))
                    {
                        genres.Add(genre);
                    }

                }
                else if (command[0] == "Drop")
                {
                    if (genres.Contains(genre))
                    {
                        genres.Remove(genre);
                    }
                }
                else if (command[0] == "Replace")
                {
                    string newGenre = command[2];
                    if (genres.Contains(genre)&&!genres.Contains(newGenre))
                    {
                        Replace(genres,genre, newGenre);
                    }
                }



                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",genres));
        }



        static void Replace(List<string> genres,string genre, string newGenre)
        {
            for (int i = 0; i < genres.Count; i++)
            {
                if (genres[i]==genre)
                {
                    genres[i] = newGenre;
                }
            }
        }
    }
}
