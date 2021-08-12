using System;
using System.Linq;

namespace _08.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();

            while (input!= "End")
            {
                int shotIndex = int.Parse(input);
                if (shotIndex<0||shotIndex>targets.Length-1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i]==-1||i==shotIndex)
                    {
                        continue;
                    }
                    else if (targets[i]>targets[shotIndex])
                    {
                        targets[i] -= targets[shotIndex];
                    }
                    else if (targets[i]<=targets[shotIndex])
                    {
                        targets[i] += targets[shotIndex];
                    }
                    
                }
                targets[shotIndex] = -1;


                input = Console.ReadLine();
            }
            int shotTargetsCount = 0;
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i]==-1)
                {
                    shotTargetsCount++;
                }
            }
            Console.WriteLine($"Shot targets: {shotTargetsCount} -> {string.Join(" ",targets)}");

        }
    }
}
