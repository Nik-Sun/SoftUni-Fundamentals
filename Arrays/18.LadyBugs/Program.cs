using System;
using System.Linq;

namespace _18.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            //The empty field;
            long[] ladyBugsPosition = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //initial ladybugs position

           
                                                                                    
            for (int i = 0; i < ladyBugsPosition.Length; i++)                       
            {
                //{  Populating the field,ignoring indexes outside the field range. }
                if (ladyBugsPosition[i]>fieldSize-1||ladyBugsPosition[i]<0)         
                {                                                                   
                    continue;                                                       
                }                                                                   
                else                                                                
                {                                                                   
                    field[ladyBugsPosition[i]] = 1;                                 
                }                                                                   
                                                                                    
            }                                                                 

            string command = Console.ReadLine();
            //{Command in type:"0 right 5"}


            while (command != "end")
            {
                
               
               
                string[] movement = command.Split();
                //---->{Breaking the command to array}
                int ladyBugIndex = int.Parse(movement[0]);
                //---->{index of the ladybug}
                string direction = movement[1];
                //---->{direction of flight}
                int flyLength = int.Parse(movement[2]);
                //---->{self-explenatory}


                if (direction=="left")   
                {
                    //{Making sure that negative numbers are handled properly}
                    flyLength *= -1;     
                }


                int destinationIndex = ladyBugIndex + flyLength;                               
                if (ladyBugIndex>field.Length-1||ladyBugIndex<0||flyLength==0)                 
                {
                    //{Making sure the destination is in the field range}//
                    command = Console.ReadLine();                                              
                  
                    continue;
                   
                }                                                                              
                                                                                               
                                                                                               
                while (field[ladyBugIndex]==1)
                //{The cycle runs until the ladybug is on the space indicated by"ladyBugIndex"}                                                                               

                {                                                                              
                    if (destinationIndex > field.Length - 1)                                   
                    {
                        //{The destination is outside the field to the right,so,the ladybug starting position becomes empty}
                        field[ladyBugIndex] = 0;
                        
                    }                                                                         
                    else if (destinationIndex < 0)                                             
                    {
                        //{The same to the left}// 
                        field[ladyBugIndex] = 0;
                               
                    }                                                                         
                    else if (field[destinationIndex] == 0)                                    
                    {
                        //{If the space is empty the ladybug "lands" on it}//
                        field[destinationIndex] = 1;                                          
                        field[ladyBugIndex] = 0;
                       
                    }                                                                          
                    else                                                                       
                    {
                        //{If the flyLength is positive the ladybug goes to the right,else, to the left}
                        if (destinationIndex>0)                                                       
                        {                                                                      
                            destinationIndex+=flyLength;                                                
                        }                                                                      
                        else                                                                   
                        {                                                                      
                            destinationIndex-=flyLength;                                                
                        }
                        
                    }                                                                          
                }

                
                command = Console.ReadLine();                                                  
                                                                                               
            }                                                                                  
            Console.WriteLine(string.Join(' ',field));                                         

            
        }
    }
}
