using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double raisedNumber=RaiseToPower(number, power);
            Console.WriteLine(raisedNumber);
        }

        static double RaiseToPower(double number, int power)
        {
            double result =1;
            for (int i = 0; i <power; i++)
            {
                result *= number ;
            }
            return result;
        }
    }
}
