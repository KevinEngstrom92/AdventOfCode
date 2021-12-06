using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleInput = @"3,4,3,1,2";

            var puzzleSplit = puzzleInput.Split(",").Select(x=> Int32.Parse(x)).ToList(); ;
            List<int> lanternFishes = new List<int>();
            List<int> newLanternFishesForNextDay = new List<int>();
            List<int> prevFishes = new List<int>();

            foreach (var item in puzzleSplit)
            {
                lanternFishes.Add(item);
                prevFishes.Add(item);

            }
            

            int days = 255;
            Console.WriteLine($"Initial State: \t" + String.Join(", ", lanternFishes));
            for (int day = 0; day <= days; day++)
            {
               
                for (int i = 0; i < lanternFishes.Count; i++)
                {
                   
                  if(lanternFishes[i] == prevFishes[i])
                    {
                        lanternFishes[i] -= 1;
                        continue;
                    }

                  if((lanternFishes[i] == 0 && prevFishes[i] == 1))
                    {
                        newLanternFishesForNextDay.Add(8);
                        lanternFishes[i] = 6;
                        prevFishes[i] = 7;
                        continue;
                    }


                  if(lanternFishes[i] == 0)
                    {
                        lanternFishes[i] = 6;
                        continue;
                    }

                    lanternFishes[i] -= 1;
                    prevFishes[i] -= 1;
                }

               
                lanternFishes.AddRange(newLanternFishesForNextDay);
                prevFishes.AddRange(newLanternFishesForNextDay);
                newLanternFishesForNextDay.Clear();
                //Console.WriteLine($"After day {day+1}\t" + String.Join(", ", lanternFishes));

            }

            Console.WriteLine($"After {days + 1} there are " + lanternFishes.Count + " fishes");
        }
    }
}
