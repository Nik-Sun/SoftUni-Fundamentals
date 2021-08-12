using System;

namespace _20.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                
                IsPalindrome(input);
                input = Console.ReadLine();
            }
        }

        static void IsPalindrome(string input)
        {
            bool isPalindrome = false;
            string reversed = string.Empty;
            for (int i = input.Length-1; i >= 0; i--)
            {
                reversed += input[i];

            }
            if (reversed==input)
            {
                isPalindrome = true;
            }
            Console.WriteLine(isPalindrome);
        }
    }
}
