using System;
using System.Text;

namespace _08.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            FileExtractor(input);

        }

        private static void FileExtractor(string input)
        {
            StringBuilder fileName = new StringBuilder();
            StringBuilder extension = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '.')
                {
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (input[j] == '\\')
                        {
                            Console.WriteLine($"File name: {fileName}\nFile extension: {extension}");
                            return;
                        }
                        fileName = fileName.Insert(0, input[j]);
                    }

                }
                extension = extension.Insert(0,input[i]);
            }
        }
    }
}
