using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleInput = @"5,1,1,4,1,1,4,1,1,1,1,1,1,1,1,1,1,1,4,2,1,1,1,3,5,1,1,1,5,4,1,1,1,2,2,1,1,1,2,1,1,1,2,5,2,1,2,2,3,1,1,1,1,1,1,1,1,5,1,1,4,1,1,1,5,4,1,1,3,3,2,1,1,1,5,1,1,4,1,1,5,1,1,5,1,2,3,1,5,1,3,2,1,3,1,1,4,1,1,1,1,2,1,2,1,1,2,1,1,1,4,4,1,5,1,1,3,5,1,1,5,1,4,1,1,1,1,1,1,1,1,1,2,2,3,1,1,1,1,1,2,1,1,1,1,1,1,2,1,1,1,5,1,1,1,1,4,1,1,1,1,4,1,1,1,1,3,1,2,1,2,1,3,1,3,4,1,1,1,1,1,1,1,5,1,1,1,1,1,1,1,1,4,1,1,2,2,1,2,4,1,1,3,1,1,1,5,1,3,1,1,1,5,5,1,1,1,1,2,3,4,1,1,1,1,1,1,1,1,1,1,1,1,5,1,4,3,1,1,1,2,1,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,1,1,1,3,3,1,2,2,1,4,1,5,1,5,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,1,1,1,5,1,1,1,4,3,1,1,4";

            var puzzleSplit = puzzleInput.Split(",").Select(x=> Int32.Parse(x)).ToList();

            long[] fishes = new long[9];
            long[] tempFishes = new long[9];

            int days = 256;

            for(int i = 0; i < puzzleSplit.Count; i++)
            {
                fishes[puzzleSplit[i]] += 1;
            }

            for(int i = 0; i < days; i++)
            {
                long nextGen = 0;
                {
                    if(fishes[0] > 0)
                    {
                        nextGen = fishes[0];
                    }

                    for(int j = 0; j < fishes.Length-1; j++)
                    {
                        tempFishes[j] = fishes[j+1];
                    }

                    tempFishes[6] += nextGen;
                    tempFishes[8] += nextGen;

                    tempFishes.CopyTo(fishes, 0);

                    for(int j = 0; j < tempFishes.Length; j++)
                    {
                        tempFishes[j] = 0;
                    }
                }
            }

            long sum = 0;
            for(int i = 0; i < fishes.Length; i++)
            {
                sum += fishes[i];
            }

            Console.WriteLine($"After day {days} there are '{sum}' fishes");
        }
    }
}
