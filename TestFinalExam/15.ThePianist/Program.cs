using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int worksCount = int.Parse(Console.ReadLine());
            List<MusicWork> favorites = new List<MusicWork>();
            for (int i = 0; i < worksCount; i++)
            {
                string[] workInfo = Console.ReadLine().Split("|");
                string workName = workInfo[0];
                string workComposer = workInfo[1];
                string workKey = workInfo[2];
                MusicWork current = new MusicWork(workName,workComposer,workKey);
                favorites.Add(current);

            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] commandInfo = input.Split("|");
                string command = commandInfo[0];
                string workName = commandInfo[1];
                int workIndex = favorites.FindIndex(x=>x.Name == workName);
                if (command == "Add")
                {
                    string workComposer = commandInfo[2];
                    string workKey = commandInfo[3];
                    if (workIndex==-1)
                    {
                        favorites.Add(new MusicWork(workName,workComposer,workKey));
                        Console.WriteLine($"{workName} by {workComposer} in {workKey} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{workName} is already in the collection!");
                    }
                   
                }
                else if (command == "Remove")
                {
                    if (workIndex != -1)
                    {
                        favorites.RemoveAt(workIndex);
                        Console.WriteLine($"Successfully removed {workName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {workName} does not exist in the collection.");
                    }
                }
                else if (command == "ChangeKey")
                {
                    if (workIndex != -1)
                    {
                        string newKey = commandInfo[2];
                        favorites[workIndex].Key = newKey;
                        Console.WriteLine($"Changed the key of {workName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {workName} does not exist in the collection.");
                    }
                   
                }
                input = Console.ReadLine();
            }

            favorites = favorites.OrderBy(x => x.Name).ThenBy(x => x.Composer).ToList();

            foreach (MusicWork piece in favorites)
            {
                Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }




        }
        class MusicWork 
        {
            public string Name { get; set; }
            public string Composer { get; set; }
            public string Key { get; set; }
            public MusicWork(string name, string composer, string key)
            {
                Name = name;
                Composer = composer;
                Key = key;
            }
        }
    }
}
