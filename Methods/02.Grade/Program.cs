using System;

namespace _02.Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeInWords(grade);
        }

         static void GradeInWords(double grade)
         {
            string text = string.Empty;
            if (grade >= 2 && grade < 3)
            {
                text = "Fail";
            }
            else if (grade>=3&&grade<3.50)
            {
                text = "Poor";
            }
            else if (grade>=3.5&&grade<4.50)
            {
                text = "Good";
            }
            else if (grade>=4.50&&grade<5.50)
            {
                text = "Very good";
            }
            else if (grade>=5.5&&grade<=6)
            {
                text = "Excellent";
            }
            Console.WriteLine(text);
         }
    }
}

