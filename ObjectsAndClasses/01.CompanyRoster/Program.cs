using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeesCount = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < employeesCount; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split();
                Employee currentEmployee = new Employee(employeeInfo[0],double.Parse(employeeInfo[1]),employeeInfo[2]);
                employees.Add(currentEmployee);

            }
            List<Departament> departaments = new List<Departament>();
            foreach (Employee item in employees)
            {
                int index = departaments.FindIndex(d=>d.Name == item.Departament);
                if (index == -1)
                {
                    Departament current = new Departament(new List<Employee> { item },item.Departament);
                    departaments.Add(current);
                }
                else
                {
                    departaments[index].Employees.Add(item);
                }
            }
            for (int i = 0; i < departaments.Count; i++)
            {
                departaments[i].Employees = departaments[i].Employees.OrderByDescending(x => x.Salary).ToList();
                departaments[i].AverageSalary = departaments[i].Employees.Select(d => d.Salary).Sum() / departaments[i].Employees.Count;
            }
            departaments = departaments.OrderByDescending(x=>x.AverageSalary).ToList();

            Console.WriteLine($"Highest Average Salary: {departaments[0].Name}");
            foreach (Employee item in departaments[0].Employees)
            {
                Console.WriteLine($"{item.Name} {item.Salary :f2}");
            }
        }
    }
    class Employee 
    {
        public Employee(string name,double salary,string departament)
        {
            Name = name;
            Salary = salary;
            Departament = departament;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Departament { get; set; }
    }
    class Departament
    {
        public Departament(List<Employee> employees,string name)
        {
            Employees = employees;
            Name = name;
            AverageSalary = 0;

        }
        public List<Employee> Employees { get; set; }
        public string Name { get; set; }
        public double AverageSalary { get; set; }
    }
}
