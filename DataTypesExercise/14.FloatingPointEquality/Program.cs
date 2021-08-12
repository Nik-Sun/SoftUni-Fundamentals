using System;

namespace _14.FloatingPointEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double difference = Math.Abs(firstNumber - secondNumber);
            bool isEqual = difference < 0.000001;

            Console.WriteLine(isEqual);



        }
    }
}
