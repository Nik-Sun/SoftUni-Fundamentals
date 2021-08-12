using System;
using System.Linq;

namespace _22.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandAsArray = command.Split();
                if (commandAsArray[0] == "exchange")
                {
                    int indexToExchangeAfter = int.Parse(commandAsArray[1]);
                    if (indexToExchangeAfter > array.Length - 1 || indexToExchangeAfter < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        array = ArrayExchangeAfterIndex(array, indexToExchangeAfter);
                    }
                }
                else if (commandAsArray[0] == "max")
                {
                    MaxEvenOrOdd(array, commandAsArray);
                }
                else if (commandAsArray[0] == "min")
                {
                    MinEvenOrOdd(array, commandAsArray);
                }
                else if (commandAsArray[0] == "first")
                {
                    FirstEvenOrOdd(array, commandAsArray);

                }
                else if (commandAsArray[0] == "last")
                {
                    LastEvenOrOdd(array, commandAsArray);
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"[{string.Join(", ",array)}]");
        }

        private static void LastEvenOrOdd(int[] array, string[] commandAsArray)
        {
            int counter = int.Parse(commandAsArray[1]);
            if (counter > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string lastEvenOrOdd = string.Empty;
            string evenOrOdd = commandAsArray[2];
            bool evenOrOddElementFound = false;
            int lastIndex = array.Length-1;
            switch (evenOrOdd)
            {
                case "even":

                    for (int i = 0; i < counter; i++)
                    {
                        for (int j = lastIndex; j >=0 ; j--)
                        {
                            if (array[j]%2==0)
                            {
                                lastEvenOrOdd += " "+array[j];
                                evenOrOddElementFound = true;
                                lastIndex = j - 1;
                                break;
                            }
                        }
                    }
                    
                    break;
                case "odd":

                    for (int i = 0; i <counter; i++)
                    {
                        for (int j = lastIndex; j >= 0; j--)
                        {
                            if (array[j] % 2 != 0)
                            {
                                lastEvenOrOdd += " " + array[j];
                                evenOrOddElementFound = true;
                                lastIndex =j-1;
                                break;
                            }
                        }
                    }
                    break;
            }
            
            string[] tempArray = lastEvenOrOdd.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            tempArray=tempArray.Reverse().ToArray();
            if (evenOrOddElementFound)
            {
                Console.WriteLine($"[{string.Join(", ", tempArray)}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        static void FirstEvenOrOdd(int[] array, string[] commandAsArray)
        {
            int counter = int.Parse(commandAsArray[1]);
            if (counter > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string firstEvenOrOdd = string.Empty;
            string evenOrOdd = commandAsArray[2];
            bool evenOrOddElementFound = false;
            int lastIndex = 0;
            switch (evenOrOdd)
            {
                case "even":
                    for (int i = 0; i < counter; i++)
                    {
                        for (int j = lastIndex; j < array.Length; j++)
                        {
                            if (array[j] % 2 == 0)
                            {
                                firstEvenOrOdd += array[j] +" ";
                                evenOrOddElementFound = true;
                                lastIndex = j+1;
                                break;
                            }
                        }
                    }
                    break;
                case "odd":
                    for (int i = 0; i < counter; i++)
                    {
                        for (int j = lastIndex; j < array.Length; j++)
                        {
                            if (array[j] % 2 != 0)
                            {
                                firstEvenOrOdd += array[j] + " ";
                                evenOrOddElementFound = true;
                                lastIndex = j + 1;
                                break;
                            }
                        }
                    }
                    break;
            }
            string[] tempArray = firstEvenOrOdd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (evenOrOddElementFound)
            {
                Console.WriteLine($"[{string.Join(", ", tempArray)}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        static void MinEvenOrOdd(int[] array, string[] commandAsArray)
        {
            switch (commandAsArray[1])
            {
                case "even":
                    int minEven = int.MaxValue;
                    int minEvenIndex = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            if (array[i] <= minEven)
                            {
                                minEven = array[i];
                                minEvenIndex = i;
                            }

                        }

                    }
                    if (minEven == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minEvenIndex);
                    }

                    break;
                case "odd":
                    int minOdd = int.MaxValue;
                    int minOddIndex = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 != 0)
                        {
                            if (array[i] <= minOdd)
                            {
                                minOdd = array[i];
                                minOddIndex = i;
                            }

                        }
                    }
                    if (minOdd == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minOddIndex);
                    }

                    break;
            }
        }
        static void MaxEvenOrOdd(int[] array, string[] commandAsArray)
        {
            switch (commandAsArray[1])
            {
                case "even":
                    int maxEven = int.MinValue;
                    int maxEvenIndex = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            if (array[i] >= maxEven)
                            {
                                maxEven = array[i];
                                maxEvenIndex = i;
                            }

                        }

                    }
                    if (maxEven==int.MinValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxEvenIndex);
                    }
                  
                    break;
                case "odd":
                    int maxOdd = int.MinValue;
                    int maxOddIndex = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 != 0)
                        {
                            if (array[i] >= maxOdd)
                            {
                                maxOdd = array[i];
                                maxOddIndex = i;
                            }

                        }
                    }
                    if (maxOdd==int.MinValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxOddIndex);
                    }
                   
                    break;
            }
        }

        static int[] ArrayExchangeAfterIndex(int[] array, int indexToExchangeAfter)
        {
            string temp = string.Empty;
            for (int i = indexToExchangeAfter; i < array.Length; i++)
            {
                if (i == indexToExchangeAfter)
                {
                    continue;
                }
                temp += array[i] + " ";

            }
            for (int i = 0; i <= indexToExchangeAfter; i++)
            {
                temp += array[i] + " ";
            }
            int[] tempArray = temp.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            array = tempArray;

            return array;
        }
    }
}
