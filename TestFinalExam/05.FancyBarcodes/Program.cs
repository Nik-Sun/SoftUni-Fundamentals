using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int barcodesCount = int.Parse(Console.ReadLine());
            string barcodeRegex = @"^@#+(?<body>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            string productRegex = @"[0-9]";
            for (int i = 0; i < barcodesCount; i++)
            {
                string input = Console.ReadLine();
                Match barcode = Regex.Match(input,barcodeRegex);
                if (barcode.Success)
                {
                    string productGroup = string.Join("",(Regex.Matches(barcode.Value,productRegex).Select(x => x.Value)));
                    if (productGroup==string.Empty)
                    {
                        productGroup = "00";
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
