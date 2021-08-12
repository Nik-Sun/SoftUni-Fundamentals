using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input!= "end")
            {
                string[] data = input.Split(" : ");
                string currentCourse = data[0];
                string studentName = data[1];
                if (courses.ContainsKey(currentCourse))
                {
                    courses[currentCourse].Add(studentName);
                }
                else
                {
                    courses.Add(currentCourse, new List<string> {studentName});
                    
                }

                input = Console.ReadLine();
            }
            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in courses)
            {
                item.Value.Sort();
            }
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}\n-- {string.Join("\n-- ",item.Value) }");
                
            }
        }
    }
}
