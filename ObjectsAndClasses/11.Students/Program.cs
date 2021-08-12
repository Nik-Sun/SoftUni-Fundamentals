using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> collection = new List<Student>();
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student currentStudent = new Student(input[0],input[1],double.Parse(input[2]));
                collection.Add(currentStudent);

            }
            List<Student> sortedCollection = collection.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in sortedCollection)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade :f2}");
            }

        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
