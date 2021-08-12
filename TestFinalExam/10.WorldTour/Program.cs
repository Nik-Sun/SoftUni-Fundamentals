using System;
using System.Text;

namespace _10.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder travelPlan = new StringBuilder(Console.ReadLine());

            string input = Console.ReadLine();
            while (input!="Travel")
            {
                string[] commandData = input.Split(":");
                string command = commandData[0];
                if (command == "Add Stop")
                {
                    int index = int.Parse(commandData[1]);
                    string stopToAdd = commandData[2];
                    bool isIndexValid = index >= 0 && index < travelPlan.Length;
                    if (isIndexValid)
                    {
                        travelPlan.Insert(index,stopToAdd);
                    }
                    
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(commandData[1]);
                    int endIndex = int.Parse(commandData[2]);
                    bool isStartIndexValid = startIndex >= 0 && startIndex < travelPlan.Length;
                    bool isEndIndexValid = endIndex >= 0 && endIndex < travelPlan.Length;
                    if (isStartIndexValid&&isEndIndexValid)
                    {
                        travelPlan.Remove(startIndex, (endIndex - startIndex + 1));
                    }
                   
                }
                else if (command == "Switch")
                {
                    string oldString = commandData[1];
                    string newString = commandData[2];
                    if (travelPlan.ToString().Contains(oldString))
                    {
                        travelPlan.Replace(oldString,newString);
                    }
                    
                }


                Console.WriteLine(travelPlan);
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {travelPlan}");
        }

       
    }
}
