using System;
using System.Collections.Generic;
using System.Linq;

namespace _18.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialCourses = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] command = input.Split(":").ToArray();
                string action = command[0];
                string lessonTitle = command[1];
                switch (action)
                {
                    case "Add":
                        if (initialCourses.Contains(lessonTitle))
                        {
                            break;
                        }
                        initialCourses.Add(lessonTitle);
                        break;
                    case "Insert":
                        if (initialCourses.Contains(lessonTitle))
                        {
                            break;
                        }
                        int index = int.Parse(command[2]);
                        initialCourses.Insert(index, lessonTitle);
                        break;
                    case "Remove":
                        initialCourses.Remove(lessonTitle);
                        initialCourses.Remove($"{lessonTitle}-Exercise");
                        break;
                    case "Swap":
                        string lessonToSwap = command[2];
                        Swap(lessonTitle, lessonToSwap, initialCourses);
                       
                        break;
                    case "Exercise":
                        if (!initialCourses.Contains(lessonTitle)&&!initialCourses.Contains($"{lessonTitle}-Exercise"))
                        {
                            initialCourses.Add(lessonTitle);
                            initialCourses.Add($"{lessonTitle}-Exercise");
                           
                        }
                        else
                        {
                            for (int i = 0; i < initialCourses.Count; i++)
                            {
                                if (initialCourses[i] == lessonTitle)
                                {
                                    if (i + 1 >= initialCourses.Count)
                                    {
                                        initialCourses.Add($"{lessonTitle}-Exercise");
                                    }
                                    else
                                    {
                                        initialCourses.Insert(i + 1, $"{lessonTitle}-Exercise");
                                    }
                                }
                            }
                        }
                        break;
                }


                input = Console.ReadLine();
            }

            for (int i = 0; i < initialCourses.Count; i++)
            {
                Console.Write($"{i + 1}.{initialCourses[i]}\n");

            }

        }

        static List<string> Swap(string lessonTitle, string lessonToSwap, List<string> initialCourses)
        {

            int lessonIndex = 0;
            int lessonToSwapIndex = 0;
            if (!initialCourses.Contains(lessonTitle) || !initialCourses.Contains(lessonToSwap))
            {
                return initialCourses;
            }
            for (int i = 0; i < initialCourses.Count; i++)
            {
                if (initialCourses[i] == lessonTitle)
                {
                    lessonIndex = i;
                }
                else if (initialCourses[i] == lessonToSwap)
                {
                    lessonToSwapIndex = i;
                }

            }
            initialCourses[lessonIndex] = lessonToSwap;
            initialCourses[lessonToSwapIndex] = lessonTitle;
            if (initialCourses.Contains($"{lessonTitle}-Exercise"))
            {
               initialCourses.Remove($"{lessonTitle}-Exercise");
                initialCourses.Insert(lessonToSwapIndex + 1, $"{lessonTitle}-Exercise");
               
            }
            if (initialCourses.Contains($"{lessonToSwap}-Exercise"))
            {
                initialCourses.Remove($"{lessonToSwap}-Exercise");
                initialCourses.Insert(lessonIndex + 1, $"{lessonToSwap}-Exercise");
               
            }
           
            return initialCourses;
        }
    }
}

