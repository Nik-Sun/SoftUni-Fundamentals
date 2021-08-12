using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();
            for (int i = 0; i < songsCount; i++)
            {
                string[] songData = Console.ReadLine().Split("_");
                Songs currentSong = new Songs();
                string type = songData[0];
                string name = songData[1];
                string time = songData[2];
                currentSong.typeList = type;
                currentSong.name = name;
                currentSong.time = time;
                songs.Add(currentSong);
            }
            string typeList = Console.ReadLine();
            if (typeList=="all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.typeList==typeList)
                    {
                        Console.WriteLine(song.name);
                    }
                }
            }
        }
    }
    class Songs
    {
        public string typeList { get; set; }
        public string name   { get; set; }
        public string time     { get; set; }
    }
}
