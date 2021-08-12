using System;
using System.Threading.Channels;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (CharectersCheck(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (LettersAndDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (isDigit(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


            if (LettersAndDigits(password) && CharectersCheck(password) && isDigit(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CharectersCheck(string password)
        {
            bool isPasswordValid = password.Length >= 6 && password.Length <= 10;

            return isPasswordValid;
        }

        static bool LettersAndDigits(string password)
        {
            bool isLetterOrDigit = true;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsSymbol(password[i]))
                {
                    isLetterOrDigit = false;
                    break;
                }

            }

            return isLetterOrDigit;
        }

        static bool isDigit(string password)
        {
            bool isDigit = false;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }

                if (counter >= 2)
                {
                    isDigit = true;
                    break;
                }
            }

            return isDigit;
        }
    }
}