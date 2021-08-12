
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            bool isListManipulated = false;
            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                string action = command[0];
               
                if (action=="Add"||action=="Remove"||action=="RemoveAt"||action=="Insert")
                {
                    int commandParameters = int.Parse(command[1]);
                    BasicManipulation(numbers, command, commandParameters);
                    isListManipulated = true;
                }
               
                else if (action== "Contains")
                {
                    int commandParameters = int.Parse(command[1]);
                    Contains(numbers, commandParameters);
                }
                else if(action== "PrintEven")
                {
                    PrintEven(numbers);
                }
                else if (action == "PrintOdd")
                {
                    PrintOdd(numbers);
                }
                else if (action=="GetSum")
                {
                    GetSum(numbers);
                }
                else if (action== "Filter")
                {
                    string condition = command[1];
                    int number = int.Parse(command[2]);
                    Filter(numbers, condition, number);
                }
                

                input = Console.ReadLine();
            }
            if (isListManipulated)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static void Filter(List<int> numbers, string condition, int number)
        {
            string result = string.Empty;
            switch (condition)
            {
                case"<":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]<number)
                        {
                            result += numbers[i] + " ";
                        }
                    }
                    break;


                case">":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > number)
                        {
                            result += numbers[i] + " ";
                        }
                    }
                    break;


                case"<=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= number)
                        {
                            result += numbers[i] + " ";
                        }
                    }
                    break;


                case">=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= number)
                        {
                            result += numbers[i] + " ";
                        }
                    }
                    break;
            }
            Console.WriteLine(result.Trim());
        }

        static void GetSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        static void PrintOdd(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void PrintEven(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.Write(numbers[i]+ " ");
                }
            }
            Console.WriteLine();
        }

        static void Contains(List<int> numbers, int commandParameters)
        {
            bool containsParameter = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]==commandParameters)
                {
                    containsParameter = true;
                    break;
                }
            }
            if (containsParameter)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }




        private static void BasicManipulation(List<int> numbers, string[] command, int commandParameters)
        {
            switch (command[0])
            {
                case "Add":
                    numbers.Add(commandParameters);
                    break;

                case "Remove":
                    numbers.Remove(commandParameters);
                    break;

                case "RemoveAt":
                    numbers.RemoveAt(commandParameters);
                    break;

                case "Insert":
                    int numberToInsert = int.Parse(command[2]);
                    numbers.Insert(numberToInsert, commandParameters);
                    break;

            }
        }
    }
}
