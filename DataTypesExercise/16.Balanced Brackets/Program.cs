using System;

namespace _16.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            byte openingBracketsCounter = 0;
            byte closingBracketsCounter = 0;
            byte differenceInBrackets = 0;

            for (int i = 0; i < linesCount; i++)
            {
                string input = Console.ReadLine();


                if (input == "(")
                {
                    openingBracketsCounter++;
                }
                else if (input == (")"))
                {
                    closingBracketsCounter++;
                }
                differenceInBrackets = (byte)Math.Abs(openingBracketsCounter - closingBracketsCounter);
            }


            if (differenceInBrackets == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }



        }
    }
}
