using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string time = ""; 
            if (minutes+30>59)
            {
                if (hours + 1 > 23)
                {
                    time = $"{hours = 0 }:{minutes - 30:d2}";
                }
                else
                {
                    time = $"{hours + 1}:{minutes - 30:d2}";
                }
                
                
            }
            
            else
            {
                time=$"{hours:d}:{minutes+30:d2}";
            }
            Console.WriteLine(time);
        }
    }
}
