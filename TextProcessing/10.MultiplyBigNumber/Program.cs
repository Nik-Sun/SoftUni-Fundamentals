using System;
using System.Text;

namespace _10.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int multiplication = 0;
            
            for (int i = firstNumber.Length-1; i >= 0; i--)
            {
               
                int currentDigit = int.Parse(firstNumber[i].ToString());
                if (secondNumber==0)
                {
                    result.Append(0);
                    break;
                }
                multiplication += currentDigit * secondNumber;
                if (i==0)
                {
                    result.Insert(0,multiplication);
                }
                else
                {
                    result.Insert(0, multiplication % 10);
                    multiplication /= 10;
                }
               
               
            }
           

            Console.WriteLine(result);
        }
    }
}
