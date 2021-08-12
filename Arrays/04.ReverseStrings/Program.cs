using System;

namespace _04.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            for (int i = array.Length -1; i >=0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
