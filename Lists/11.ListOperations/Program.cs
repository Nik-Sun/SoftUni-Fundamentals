using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] command = input.Split().ToArray();
                string action = command[0];
                if (action=="Shift")
                {
                    string shiftDirection = command[1];
                    int count = int.Parse(command[2]);
                    switch (shiftDirection)
                    {
                        case "left":
                            for (int i = 0; i < count; i++)
                            {
                                ShiftLeft(collection);
                            } 
                            break;

                        case "right":
                            for (int i = 0; i < count; i++)
                            {
                                ShiftRight(collection);
                            }
                            break;
                    }

                }
                else if (action=="Add")
                {
                    int parameters = int.Parse(command[1]);
                    collection.Add(parameters);
                }

                else if (action=="Insert")
                {
                    int parameters = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index>=collection.Count||index<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        collection.Insert(index, parameters);
                    }
                   
                }
                else if (action== "Remove")
                {
                    int parameters = int.Parse(command[1]);
                    if (parameters>=collection.Count || parameters<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        collection.RemoveAt(parameters);
                    }
                    
                }
               
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ",collection));
        }

        private static void ShiftRight(List<int> collection)
        {
            int temp = collection[collection.Count - 1];
            collection.RemoveAt(collection.Count - 1);
            collection.Insert(0, temp);
        }

        private static void ShiftLeft(List<int> collection)
        {
            int temp = collection[0];
            collection.RemoveAt(0);
            collection.Add(temp);
        }
    }
}
