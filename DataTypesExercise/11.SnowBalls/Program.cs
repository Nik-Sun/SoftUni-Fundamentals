using System;

namespace _11.SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfSnowBalls = sbyte.Parse(Console.ReadLine());
            System.Numerics.BigInteger bestSnowballValue = 0;
            string result = string.Empty;
            for (int i = 0; i < numberOfSnowBalls; i++)
            {
                short snowInSnowball = short.Parse(Console.ReadLine());
                short timeForSnowball = short.Parse(Console.ReadLine());
                byte qualityOfSnowball = byte.Parse(Console.ReadLine());
                if ((System.Numerics.BigInteger)Math.Pow((snowInSnowball / timeForSnowball), qualityOfSnowball) > bestSnowballValue)
                {
                    bestSnowballValue = System.Numerics.BigInteger.Pow((snowInSnowball / timeForSnowball), qualityOfSnowball);
                    result = $"{snowInSnowball} : {timeForSnowball} = {bestSnowballValue} ({qualityOfSnowball})";
                }


            }
            Console.WriteLine(result);
        }
    }
}
