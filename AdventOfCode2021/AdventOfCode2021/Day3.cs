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

            //this is the tricky part
            Day3Binary[12] day3Array = { new Day3Binary();
                new Day3Binary();
                new Day3Binary();
                new Day3Binary();
                new Day3Binary();
                new Day3Binary();
                new Day3Binary();
                new Day3Binary();
                new Day3Binary();
                new Day3Binary();
                new Day3Binary();
                new Day3Binary();
             };

            foreach (var line in lines)
            {
                //
            }
        }
    }
}
