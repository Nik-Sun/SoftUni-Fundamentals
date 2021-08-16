using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int membersCount = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < membersCount; i++)
            {
                string[] memberInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Person member = new Person(memberInfo[0],int.Parse(memberInfo[1]));
                family.AddMember(member);

            }
            family.PrintOldestMember();
        }
    }
    class Person 
    {
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family 
    {
        public Family()
        {
            Members = new List<Person>();
        }
        public List<Person> Members  { get; set; }

        public void AddMember(Person member)
        {
           Members.Add(member);
        }
        public void PrintOldestMember()
        {
           Members = Members.OrderByDescending(a=>a.Age).ToList();

            Console.WriteLine($"{Members[0].Name} {Members[0].Age}");
        }
    }
}
