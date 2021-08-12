using System;

namespace _15.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            PasswordChecker(input);
        }

        static void PasswordChecker(string input)
        {
            int errorCount= 0;
            if (!LengthCheker(input))
            {
                errorCount++;
            }
            if (!ContentChecker(input))
            {
                errorCount++;
            }
            if (!DigitsChecker(input))
            {
                errorCount++;
            }
            if (errorCount==0)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool DigitsChecker(string input)
        {
            bool isValid = false;
            int countOfDigitsInInput = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    countOfDigitsInInput++;
                }
            }
            if (countOfDigitsInInput>=2)
            {
                isValid = true;
                return isValid;
            }
            Console.WriteLine("Password must have at least 2 digits");
            return isValid;
        }

        static bool ContentChecker(string input)
        {
            bool isVAlid = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    isVAlid = true;
                }
                else if (input[i]>=65&& input[i]<=90)
                {
                    isVAlid = true;
                }
                else if (input[i]>=97&& input[i]<=122)
                {
                    isVAlid = true;
                }
                else
                {
                    isVAlid = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    return isVAlid;
                }
            }
            return isVAlid;
        }

        static bool LengthCheker(string input)
        {
            bool isValid = false;
            if (input.Length >= 6 && input.Length <= 10)
            {
                isValid = true;
                return isValid;
            }
            Console.WriteLine("Password must be between 6 and 10 characters");
            return isValid;
        }
    }
}
