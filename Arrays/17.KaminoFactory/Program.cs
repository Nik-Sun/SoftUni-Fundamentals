using System;
using System.Linq;

namespace _17.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int rotationsCounter = 0;
            int bestSequenceRotation = 0;
            int bestSum = 0;
            int bestSubsequence = 0;
            int bestSubsequenceIndex = 0;
            string bestSequence = string.Empty;

            while (input != "Clone them!")
            {

                string inputAsString = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        inputAsString += input[i] + " ";
                    }
                }
                int[] sequence = inputAsString.Trim().Split().Select(int.Parse).ToArray();
                int counterForOnes = 0;
                int subsequenceSum = 0;
                int subsequence = 0;
                int sequenceIndex = 0;
                rotationsCounter++;
                for (int i = 0; i < sequence.Length; i++)
                {
                    if (subsequence < counterForOnes)
                    {
                        subsequence = counterForOnes;
                        sequenceIndex = i - counterForOnes;
                    }
                    if (sequence[i] == 1)
                    {
                        subsequenceSum++;
                        counterForOnes++;
                    }
                    else
                    {
                        counterForOnes = 0;
                    }

                }
                if (subsequence > bestSubsequence)
                {
                    bestSubsequence = subsequence;
                    bestSubsequenceIndex = sequenceIndex;
                    bestSum = subsequenceSum;
                    bestSequence = string.Join(' ', sequence);
                    bestSequenceRotation = rotationsCounter;  

                }
                else if (subsequence==bestSubsequence)
                {
                    if (bestSubsequenceIndex > sequenceIndex)
                    {
                        bestSubsequenceIndex = sequenceIndex;
                        bestSum = subsequenceSum;
                        bestSequence = string.Join(' ', sequence);
                        bestSequenceRotation = rotationsCounter;


                    }
                    else if (bestSubsequenceIndex==sequenceIndex)
                    {
                        if (bestSum < subsequenceSum)
                        {
                            bestSum = subsequenceSum;
                            bestSequence = string.Join(' ', sequence);
                            bestSequenceRotation = rotationsCounter;
                        }
                    }
                    
                
                }



                input = Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {bestSequenceRotation} with sum: {bestSum}.\n{bestSequence}");

        }
    }
}
