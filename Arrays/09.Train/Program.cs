using System;

namespace _09.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsInTrain = int.Parse(Console.ReadLine());
            int[] train = new int[wagonsInTrain];
            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            int passsangersCount = 0;
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] + " ");
                passsangersCount += train[i];
            }
            Console.WriteLine($"\n{passsangersCount}") ;
        }
    }
}
