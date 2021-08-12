using System;

namespace _13VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result =VowelCounter(input);
            Console.WriteLine(result);
            
        }

        static int VowelCounter(string input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case'a':
                    case'A':
                    case'E':
                    case'e':
                    case'Y':
                    case'y':
                    case'U':
                    case'u':
                    case'I':
                    case'i':
                    case'O':
                    case 'o':
                        result++;
                        break;
                }
            }
            return result;
        }
    }
}
