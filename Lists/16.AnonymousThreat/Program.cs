using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine()
                .Split()
                .ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] command = input.Split().ToArray();
                string action = command[0];

               

                if (action == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    string temp = string.Empty;
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        if (i>collection.Count-1 || i<0)
                        {
                            continue;
                        }
                        temp += collection[i];
                        collection[i] = string.Empty;
                       
                    }

                    
                   
                    if (startIndex<=0)
                    {
                        collection.Insert(0,temp);
                    }
                    else if(startIndex>=0&&startIndex<=collection.Count -1)
                    {
                        collection.Insert(startIndex,temp);
                    }
                    else if (collection.Count==startIndex)
                    {
                        collection.Add(temp);
                    }

                    

                }
                else if (action == "divide")
                {
                    int index = int.Parse(command[1]);
                    int parts = int.Parse(command[2]);
                    
                    string temp = collection[index];
                    string temp2 = string.Empty;
                    int seperatePartsLength = temp.Length / parts;
                    int extraPartsInLastElement = temp.Length % parts;
                    int startingIndex = 0;
                    for (int i = 0; i < seperatePartsLength+extraPartsInLastElement; i++)
                    {
                        temp2 += temp[temp.Length-1-i];
                    }
                    temp2= Reverse(temp2);
                    temp2 += ' ';
                    string temp3 = string.Empty;
                    for (int i = 0; i < parts-1; i++)
                    {
                        for (int j = startingIndex; j < seperatePartsLength+startingIndex; j++)
                        {
                            temp3 += temp[j];
                        }
                        startingIndex += seperatePartsLength;
                        temp3 += ' ';
                    }
                    temp2 = temp2.Trim();
                    temp3 =temp3.Trim();
                    collection.RemoveAt(index);
                    collection.Insert(index,temp2);
                    collection.Insert(index, temp3);

                    
                }
                while (collection.Contains(string.Empty))
                {
                    collection.Remove(string.Empty);
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(" ",collection).Trim());
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
