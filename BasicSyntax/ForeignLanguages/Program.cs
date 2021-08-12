using System;

namespace ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string languageSpoken = "";
            switch (country)
            {
                case "USA":
                case "England":
                    languageSpoken = "English";
                    break;
                case "Mexico":
                case "Argentina":
                case "Spain":
                    languageSpoken = "Spanish";
                    break;
                    
                default:
                    languageSpoken = "unknown";
                    break;
            }
            Console.WriteLine(languageSpoken);
        }
    }
}
