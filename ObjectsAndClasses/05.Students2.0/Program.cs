
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
                string firstName = currentStudentInfo[0];
                string lastName = currentStudentInfo[1];
                int age = int.Parse(currentStudentInfo[2]);
                string city = currentStudentInfo[3];
                
                if (StudentExists(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                else
                {
                    Student currentStudent = new Student();
                    currentStudent.FirstName = firstName;
                    currentStudent.LastName = lastName;
                    currentStudent.Age = age;
                    currentStudent.City = city;
                    students.Add(currentStudent);
                }

                input = Console.ReadLine();
            }
            string cityFilter = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].City == cityFilter)
                {
                    Console.WriteLine($"{students[i].FirstName} {students[i].LastName} is {students[i].Age} years old.");
                }
            }

        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student foundStudent = null;
            foreach (var student in students)
            {
                if (student.FirstName==firstName&&student.LastName==lastName)
                {
                    foundStudent = student;
                }
            }
            return foundStudent;
        }

        static bool StudentExists(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (firstName == student.FirstName && lastName == student.LastName)
                {
                    return true;
                }
            }
            return false;
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
