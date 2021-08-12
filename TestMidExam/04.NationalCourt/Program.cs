using System;

namespace _04.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int efficencyPerHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;
            int hours = 0;
            while (peopleCount>0)
            {
                hours++;
                if (hours%4==0)
                {
                    continue;
                }
                peopleCount -= efficencyPerHour;
            }
            
            Console.WriteLine($"Time needed: {hours}h.");
           
        }
    }
}
