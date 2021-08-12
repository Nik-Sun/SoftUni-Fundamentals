using System;
using System.Text;
namespace _20._PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] arrayFirst = new string[input];
            int[] arraySecond = new int[input];
            for (int i = 0; i < arraySecond.Length; i++)
            {
                arraySecond[i] = i + 1;
            }
            for (int i = 0; i < arrayFirst.Length; i++)
            {
                if (i==0)
                {
                    arrayFirst[i] += string.Join(' ',arraySecond[0]);
                    continue;
                }
                if (i==2)
                {
                    arrayFirst[i] += arraySecond[0].ToString();
                }

                

            }
            
            Console.WriteLine(string.Join("\n",arrayFirst));
        }
    }
}
