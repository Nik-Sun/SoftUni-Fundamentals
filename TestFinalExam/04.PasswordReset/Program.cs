using System;
using System.Text;

namespace _04.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder(Console.ReadLine());
            string input = Console.ReadLine();
            while (input!="Done")
            {
                string[] commandData = input.Split();
                string command = commandData[0];
                if (command=="TakeOdd")
                {
                    password = TakeOdd(password);
                }
                else if (command=="Cut")
                {
                    int index = int.Parse(commandData[1]);
                    int length = int.Parse(commandData[2]);
                    password = Cut(password, index, length);
                }
                else if (command== "Substitute")
                {
                   
                    string substring = commandData[1];
                    string substitute = commandData[2];
                    if (password.ToString().Contains(substring))
                    {
                        password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }

        static StringBuilder Cut(StringBuilder password, int index, int length)
        {
            
            password.Remove(index,length);
            Console.WriteLine(password);
            return password;
        }

        static StringBuilder TakeOdd(StringBuilder password)
        {
            StringBuilder tempPassword = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                if (i%2!=0)
                {
                    tempPassword.Append(password[i]);
                }
            }
            Console.WriteLine(tempPassword);
            return tempPassword;
        }
    }
}
