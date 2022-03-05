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

            var window1 = new Models.ThreeMemberWindow();
            var window2 = new Models.ThreeMemberWindow();

            window1.Add(1);
            Console.WriteLine($"Sum of window1 {window1.Sum()}");
            window1.Add(2);
            Console.WriteLine($"Sum of window1 {window1.Sum()}");
            window1.Add(3);
            Console.WriteLine($"Sum of window1 {window1.Sum()}");
            window1.Add(4);
            Console.WriteLine($"Sum of window1 {window1.Sum()}");
            window1.Add(5);
            Console.WriteLine($"Sum of window1 {window1.Sum()}");
            window1.Add(6);
            Console.WriteLine($"Sum of window1 {window1.Sum()}");
        }
    }
}
