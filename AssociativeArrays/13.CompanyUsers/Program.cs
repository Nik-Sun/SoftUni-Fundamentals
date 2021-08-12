using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (input !="End")
            {
                string[] data = input.Split(" -> ");
                string companyName = data[0];
                string employeeId = data[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                   
                }
                else
                {
                    companies.Add(companyName, new List<string> {employeeId });
                }
               

                input = Console.ReadLine();
            }
            companies = companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}\n-- {string.Join("\n-- ",item.Value)}");
            }
        }
    }
}
