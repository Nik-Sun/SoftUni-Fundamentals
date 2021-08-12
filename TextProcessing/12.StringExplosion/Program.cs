using System;
using System.Text;

namespace _12.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            int bombStrength = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
                if (bombStrength>0&&text[i]!='>')
                {
                    text.Replace(text[i], '@', i, 1);
                    bombStrength--;
                }

                if (text[i]=='>')
                {
                   bombStrength+=int.Parse(text[i+1].ToString());
                }
                
            }
            text.Replace('@','\0');
            Console.WriteLine(text);
        }
    }
}
