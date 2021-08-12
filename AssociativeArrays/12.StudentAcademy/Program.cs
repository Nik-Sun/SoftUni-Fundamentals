using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string,List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < rows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<double> {grade});
                }
            }
            foreach (var item in students)
            {
                double averageGrade = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    averageGrade += item.Value[i];
                }
                averageGrade /= item.Value.Count();
                item.Value.Clear();
                item.Value.Add(averageGrade);
            }
            students = students.Where(x =>x.Value.Sum() >=4.5).OrderByDescending(x => x.Value.Sum()).ToDictionary(x =>x.Key,x=>x.Value);
            foreach (var item in students)
            {
                 Console.WriteLine($"{item.Key} -> {item.Value[0] :f2}");
            }
           
        }
    }
}
