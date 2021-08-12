using System;
using System.Collections.Generic;

namespace _06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                if (IsUsernameValid(usernames[i]))
                {
                    validUsernames.Add(usernames[i]);
                }

            }
            Console.WriteLine(string.Join("\n",validUsernames));


        }

        static bool IsUsernameValid(string v)
        {
            if (v.Length <3 || v.Length > 16)
            {
                return false;
            }
            for (int i = 0; i < v.Length; i++)
            {

                if (char.IsDigit(v[i]) || char.IsLetter(v[i]) || v[i] == '_' || v[i] == '-')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
