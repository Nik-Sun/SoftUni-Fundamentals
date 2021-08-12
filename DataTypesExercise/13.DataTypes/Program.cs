using System;

namespace _13.DataTypes
{
    class Program
    {
        static void Main(string[] args)

        {
            var input = Console.ReadLine();
            
            while (input!= "END")
            {
                int dataInt;
                double dataFloat;
                char dataChar;
                bool dataIsBool = false;
                string dataType = string.Empty;

                if (int.TryParse(input, out dataInt))
                {
                    dataType = "integer";
                }
                else if (double.TryParse(input, out dataFloat))
                {
                    dataType = "floating point";
                }
                else if (char.TryParse(input, out dataChar ))
                {
                    dataType = "character";
                }
                else if (bool.TryParse(input,out dataIsBool))
                {
                    dataType = "boolean";
                }
                else
                {
                    dataType = "string";
                }
                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }

        }
    }
}
