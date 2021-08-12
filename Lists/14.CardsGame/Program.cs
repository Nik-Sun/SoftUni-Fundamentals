using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerCards = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            
            int shortestDeck = firstPlayerCards.Count;

            while (firstPlayerCards.Count != 0 && secondPlayerCards.Count != 0)
            {
                

                for (int i = 0; i < firstPlayerCards.Count; i++)
                {
                    if (firstPlayerCards[i] > secondPlayerCards[i])
                    {
                        firstPlayerCards.Add(firstPlayerCards[i]);
                        firstPlayerCards.Add(secondPlayerCards[i]);
                        firstPlayerCards[i] = 0;
                        secondPlayerCards[i] = 0;

                    }
                    else if (firstPlayerCards[i] == secondPlayerCards[i])
                    {
                        firstPlayerCards[i] = 0;
                        secondPlayerCards[i] = 0;
                    }
                    else
                    {
                        secondPlayerCards.Add(secondPlayerCards[i]);
                        secondPlayerCards.Add(firstPlayerCards[i]);
                        firstPlayerCards[i] = 0;
                        secondPlayerCards[i] = 0;
                    }
                   
                }

                firstPlayerCards.RemoveAll(x=>x==0);
                secondPlayerCards.RemoveAll(x => x == 0);

                if (firstPlayerCards.Count < secondPlayerCards.Count)
                {
                    shortestDeck = firstPlayerCards.Count;
                }
                else
                {
                    shortestDeck = secondPlayerCards.Count;
                }

            }
            if (firstPlayerCards.Count!=0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }

        }
    }
}
