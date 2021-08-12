using System;
using System.Collections.Generic;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (input != "end")
            {
                string[] currentStudentInfo = input.Split();
                Student currentStudent = new Student();
                currentStudent.FirstName = currentStudentInfo[0];
                currentStudent.LastName = currentStudentInfo[1];
                currentStudent.Age = int.Parse(currentStudentInfo[2]);
                currentStudent.City = currentStudentInfo[3];
                students.Add(currentStudent);


                input = Console.ReadLine();
            }
            string cityFilter = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].City==cityFilter)
                {
                    Console.WriteLine($"{students[i].FirstName} {students[i].LastName} is {students[i].Age} years old.");
                }
            }

        }
    }
    class Student 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
