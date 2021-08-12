using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombNumAndPow = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombNum = bombNumAndPow[0];
            int bombPow = bombNumAndPow[1];

            //1 2 2 4 2 2 2 9

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == bombNum)
                {
                    for (int j = i - bombPow; j <= i + bombPow; j++)
                    {
                        if (j >= sequence.Count || j < 0)
                        {
                            continue;
                        }
                        sequence[j] = 0;
                    }
                }

            }

            Console.WriteLine(sequence.Sum());


        }
    }
}
