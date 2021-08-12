using System;
using System.Linq;

namespace _13.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < userArray.Length; i++)
            {
                bool flag = true;
                for (int j = i+1; j < userArray.Length; j++)
                {
                    if (userArray[i]<=userArray[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.Write(userArray[i] + " ");
                }
            }
        }
    }
}
