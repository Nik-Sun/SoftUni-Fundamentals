using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int coursesCount = 0;
            for (int i = 0; i <numberOfPeople; i+=elevatorCapacity)
            {
                coursesCount++;
            }
            Console.WriteLine(coursesCount);
        }
    }
}
