using System;

namespace _01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            double countOfLectures = int.Parse(Console.ReadLine());
            int aditionalBonus = int.Parse(Console.ReadLine());

            double totalBonus = 0;
            int maxAttendece = 0;
            double maxBonus = 0;
            for (int i = 0; i < countOfStudents; i++)
            {
                double attendanceCount = int.Parse(Console.ReadLine());
                totalBonus = (attendanceCount / countOfLectures) * (5 + aditionalBonus);
                if (totalBonus>maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendece = (int)attendanceCount;
                }

            }
            
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendece} lectures.");
        }
    }
}
