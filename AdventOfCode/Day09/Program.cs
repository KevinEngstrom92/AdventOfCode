using System;
using System.Collections.Generic;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleInput = @"2199943210
3987894921
9856789892
8767896789
9899965678";

            var inputSplit = puzzleInput.Split("\r\n");
            List<int?> toCheck = new List<int?>();
            int low = 0;
            List<(int,int)> lowPoints = new List<(int, int)>;
            for (int i = 0; i < inputSplit.Length; i++)
            {
                Console.WriteLine();
                for (int ch = 0; ch < inputSplit[i].Length; ch++)
                {
                    int? up = null;
                    int? down = null;
                    int? left = null;
                    int? right = null;


                    toCheck.Clear();

                    if (i == 0)
                    {
                        if (ch == 0)
                        {
                            down = Convert.ToInt32(inputSplit[i + 1][ch] - '0');
                            right = Convert.ToInt32(inputSplit[i][ch + 1] - '0');
                        }

                        else if (ch == inputSplit[i].Length - 1)
                        {
                            down = Convert.ToInt32(inputSplit[i + 1][ch] - '0');
                            left = Convert.ToInt32(inputSplit[i][ch - 1] - '0');
                        }
                        else
                        {
                            down = Convert.ToInt32(inputSplit[i + 1][ch] - '0');
                            left = Convert.ToInt32(inputSplit[i][ch - 1] - '0');
                            right = Convert.ToInt32(inputSplit[i][ch + 1] - '0');
                        }
                    }

                    else if (i == inputSplit.Length - 1)
                    {
                        if (ch == 0)
                        {
                            up = Convert.ToInt32(inputSplit[i - 1][ch] - '0');
                            right = Convert.ToInt32(inputSplit[i][ch + 1] - '0');
                        }

                        else if (ch == inputSplit[i].Length - 1)
                        {
                            up = Convert.ToInt32(inputSplit[i - 1][ch] - '0');
                            left = Convert.ToInt32(inputSplit[i][ch - 1]) - '0';
                        }
                        else
                        {
                            up = Convert.ToInt32(inputSplit[i - 1][ch] - '0');
                            left = Convert.ToInt32(inputSplit[i][ch - 1] - '0');
                            right = Convert.ToInt32(inputSplit[i][ch + 1] - '0');
                        }
                    }
                    else
                    {
                        if (ch == 0)
                        {
                            up = Convert.ToInt32(inputSplit[i - 1][ch] - '0');
                            down = Convert.ToInt32(inputSplit[i + 1][ch] - '0');
                            right = Convert.ToInt32(inputSplit[i][ch + 1] - '0');
                        }
                        else if (ch == inputSplit[i].Length - 1)
                        {
                            up = Convert.ToInt32(inputSplit[i - 1][ch] - '0');
                            down = Convert.ToInt32(inputSplit[i + 1][ch] - '0');
                            left = Convert.ToInt32(inputSplit[i][ch - 1] - '0');
                        }
                        else
                        {
                            up = Convert.ToInt32(inputSplit[i - 1][ch] - '0');
                            down = Convert.ToInt32(inputSplit[i + 1][ch] - '0');
                            left = Convert.ToInt32(inputSplit[i][ch - 1] - '0');
                            right = Convert.ToInt32(inputSplit[i][ch + 1] - '0');
                        }


                    }




                    if (up != null)
                    {
                        toCheck.Add(up);
                    }
                    if (down != null)
                    {
                        toCheck.Add(down);
                    }
                    if (left != null)
                    {
                        toCheck.Add(left);
                    }
                    if (right != null)
                    {
                        toCheck.Add(right);
                    }


                    for (int count = 0; count < toCheck.Count; count++)
                    {

                        if (Convert.ToInt32(inputSplit[i][ch] - '0') >= toCheck[count])
                        {
                            Console.Write(inputSplit[i][ch]);
                            break;
                        }
                        if (count == toCheck.Count - 1)
                        {
                            low += (Convert.ToInt32(inputSplit[i][ch] - '0') + 1);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{inputSplit[i][ch]}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }



                }
            }

            //GOLD


            //GOLD END
            Console.WriteLine("\n\nSUM:\t" + low);
        }

    }
}
