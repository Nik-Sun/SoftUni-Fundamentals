using System;

namespace _11.RefactorVolumeOfPiramyd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = ((lenght * width) * height) / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");

        }
    }
}
