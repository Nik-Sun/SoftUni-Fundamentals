using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input!="End")
            {
                string[] command = input.Split();
                int index = int.Parse(command[1]);
                if (command[0]=="Shoot")
                {
                    
                    int power = int.Parse(command[2]);
                    Shoot(targets, index, power);
                }
                else if (command[0] == "Add")
                {
                    int value = int.Parse(command[2]);
                    if (index>targets.Count-1||index<0)
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else
                    {
                        targets.Insert(index,value);
                    }
                }
                else if (command[0] == "Strike")
                {
                    int radius = int.Parse(command[2]);
                    Strike(targets, index, radius);
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|",targets));
        }

        static void Strike(List<int> targets, int index, int radius)
        {
            if (index+radius>targets.Count-1||index-radius<0)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            else
            {
                for (int i = index-radius; i <=index + radius; i++)
                {
                    targets[i]=0;
                }
            }
            targets.RemoveAll(x => x == 0);
        }

        static void Shoot(List<int> targets, int index, int power)
        {
            if (index>targets.Count-1||index<0)
            {
                return;
            }
            else
            {
                targets[index] -= power;
            }
            if (targets[index]<=0)
            {
                targets[index]=0;
            }
            targets.RemoveAll(x => x == 0);
        }
    }
}
