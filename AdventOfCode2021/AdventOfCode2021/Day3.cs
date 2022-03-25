using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2021.Common;
using AdventOfCode2021.Models;

namespace AdventOfCode2021
{
    public static class Day3
    {
        public static void DoPart1()
        {
            Console.WriteLine("In Day 3, Part 1");

            var lines = ReadFileHelper.ReadTextFileReturnContents("Day3.txt");

            if (lines == null)
            {
                Console.WriteLine("Day 3 text file is empty");
                return;
            }

            //this is the tricky part
            Day3Binary[] day3Array = new Day3Binary[12];
            for (int i = 0; i < 12; i++)
                day3Array[i] = new Day3Binary();

            foreach (var line in lines)
            {
                //break the line up into the 12 parts of the binary string
                for (int i = 0; i < 12; i++)
                {
                    char c = line.ElementAt(i);
                    day3Array[i].AddBit(c);
                }
            }

            //construct the gamma and epsilon rate values, as binary strings of numbers
            var gammaRateSB = new StringBuilder();
            var epsilonRateSB = new StringBuilder();

            for (int i = 0; i < 12; i++)
            {
                gammaRateSB.Append(day3Array[i].MostCommonBit());
                epsilonRateSB.Append(day3Array[i].LeastCommonBit());
            }

            //convert the binary representation of gamma and epsilon rates to decimarl
            int gammaRate = Convert.ToInt32(gammaRateSB.ToString(), 2);
            int epsilonRate  = Convert.ToInt32(epsilonRateSB.ToString(), 2);

            var powerConsumption = gammaRate * epsilonRate;

            Console.WriteLine($"The power consumption is {powerConsumption}");
        }

        public static void DoPart2()
        {
            Console.WriteLine("In Day 3, Part 2");

            var lines = ReadFileHelper.ReadTextFileReturnContents("Day3.txt");

            if (lines == null)
            {
                Console.WriteLine("Day 3 text file is empty");
                return;
            }

            /*
             * This is the tricky part for day 3, part 2. We've got to determine the bit criteria
             * (oxygen generator rating and CO2 scrubber rating), which are different values.
             * It would be best to create a helper function that I can feed lines to, in two
             * separate calls. After all, there's no
             * guarantee that the filtering for oxygen generator rating and CO2 scrubber rating
             * will result in the same leftovers with each step.
             */
        }
    }
}
