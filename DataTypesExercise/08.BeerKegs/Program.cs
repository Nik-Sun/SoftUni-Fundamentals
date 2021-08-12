using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte beerKegsCount = byte.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            decimal biggestKegVolume = 0;
            for (int i = 0; i < beerKegsCount; i++)
            {
                string modelKeg=Console.ReadLine();
                float radiusOfKeg = float.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());
                decimal KegVolume = (decimal)(Math.PI * (Math.Pow(radiusOfKeg,2)) * heightOfKeg);
                if (KegVolume>biggestKegVolume)
                {
                    biggestKeg = modelKeg;
                    biggestKegVolume = KegVolume;
                 
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
