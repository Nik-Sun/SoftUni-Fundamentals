using System;

namespace _12.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayToRotate = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                string temp = string.Empty;
                temp = arrayToRotate[0];

                for (int j = 0; j < arrayToRotate.Length; j++)
                {
                    if (j==arrayToRotate.Length-1)
                    {
                        arrayToRotate[^1] = temp;
                        break;
                    }
                    
                    arrayToRotate[j] = arrayToRotate[j + 1];
                   
                }

            }
            for (int i = 0; i < arrayToRotate.Length; i++)
            {
                Console.Write(arrayToRotate[i] + " ");
            }
        }
    }
}
