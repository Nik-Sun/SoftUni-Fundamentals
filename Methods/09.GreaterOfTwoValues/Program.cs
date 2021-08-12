using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            string result = string.Empty;
            if (valueType=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                result=GetMax(a, b).ToString();
            }
            else if (valueType=="char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                result=GetMax(a,b).ToString();
            }
            else if (valueType=="string")
            {
                string a = Console.ReadLine();
                string b= Console.ReadLine();
                result=GetMax(a,b);

            }
            Console.WriteLine(result);
        }

        static int GetMax(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            return b;
        }
        static char GetMax(char a, char b) 
        {
            if (a>b)
            {
                return a;
            }
            return b;
        }
        static string GetMax(string a, string b) 
        {
            if (a.CompareTo(b)==1)
            {
                return a;
            }
            return b;
        }
    }
}
