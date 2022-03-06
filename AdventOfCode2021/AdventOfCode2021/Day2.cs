using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    public static class Day2
    {
        public static void DoDay2()
        {
            Console.WriteLine("In Day 2");

            //get lines
            var lines = Day1.ReadDay1File();

            if (lines == null)
            {
                Console.WriteLine("Day1 data file had no data");
                return;
            }

            var window1 = new Models.ThreeMemberWindow();   //first window
            var window2 = new Models.ThreeMemberWindow();   //second window, always one value behind window1

            int previousRead = 0;

            //window1.Add(1);
            //Console.WriteLine($"Sum of window1 {window1.Sum()}");
            //window1.Add(2);
            //window2.Add(2);
            //Console.WriteLine($"Sum of window1 {window1.Sum()}");
            //window1.Add(3);
            //window2.Add(3);
            //Console.WriteLine($"Sum of window1 {window1.Sum()}");
            //window1.Add(4);
            //window2.Add(4);
            //Console.WriteLine($"Sum of window1 {window1.Sum()}");
            //window1.Add(5);
            //window2.Add(5);
            //Console.WriteLine($"Sum of window1 {window1.Sum()}");
            //window1.Add(6);
            //window2.Add(6);
            //Console.WriteLine($"Sum of window1 {window1.Sum()}");

            int sum1 = -1, sum2 = -1;
            int numOfIncreases = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                int integerRead = 0;

                //only handle integer values
                if (int.TryParse(line, out integerRead))
                {
                    window1.Add(integerRead);
                    if (i > 0)
                    {
                        window2.Add(previousRead);
                    }

                    sum1 = window1.Sum();
                    sum2 = window2.Sum();
                    if (sum1 > 0 && sum2 == -1)
                    {
                        //now we can start reporting
                        Console.WriteLine($"{sum1} (N/A - no previous sum)");
                    }
                    else if (sum1 > 0 && sum2 > 0)
                    {
                        //continue reporting
                        if (sum1 < sum2)
                        {
                            Console.WriteLine($"{sum2} (decrease)");
                        }
                        else if (sum1 == sum2)
                        {
                            Console.WriteLine($"{sum2} (no change)");
                        }
                        else
                        {
                            Console.WriteLine($"{sum2} (increased)");
                            numOfIncreases++;
                        }
                    }

                    if (i > 0)
                    {
                        previousRead = integerRead;
                    }
                }
            }

            Console.WriteLine($"The number of sums larger than the previous sum is {numOfIncreases}");
        }
    }
}
