using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deckOfCards = Console.ReadLine()
                .Split(":")
                .ToList();
            List<string> newDeck = new List<string>();
            string input = Console.ReadLine();

            while (input!="Ready")
            {
                string[] command = input.Split();
                string action = command[0];
                string card = command[1];
                switch (action)
                {
                    case "Add":
                        if (deckOfCards.Contains(card))
                        {
                            newDeck.Add(card);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(command[2]);

                        if (deckOfCards.Contains(card)&&index>=0&&index<newDeck.Count)
                        {
                            newDeck.Insert(index, card);
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        break;
                    case "Remove":
                        if (newDeck.Contains(card))
                        {
                            newDeck.Remove(card);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Swap":
                        string newCard = command[2];
                        Swap(newDeck, card, newCard);
                        break;
                    case "Shuffle":
                        newDeck.Reverse();
                        break;
                }

                
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",newDeck));
        }




        static void Swap(List<string> newDeck, string card, string newCard)
        {
            for (int i = 0; i < newDeck.Count; i++)
            {
                if (newDeck[i]==card)
                {
                    newDeck[i] = newCard;
                }
                else if (newDeck[i]==newCard)
                {
                    newDeck[i] = card;
                }
            }
        }
    }
}
