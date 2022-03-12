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

            foreach (var line in lines)
            {
                //break the line up into the 12 parts of the binary string
                for (int i = 0; i < 12; i++)
                {
                    char c = line.ElementAt(i);
                    day3Array[i].AddBit(c);
                }
            }
        }
    }
}
