using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    public static class Day2Prime
    {
        public static void DoDay2Prime()
        {
            //Should this be Day 3? No
            Console.WriteLine("In Day 2 - Prime");

            var lines = ReadDay2PrimeFile();

            if (lines == null)
            {
                Console.WriteLine("Day 2 Prime file is empty");
                return;
            }

            int horizontalPosition = 0;
            int depth = 0;

            //read through each line

            //split the line using a space as the delimiter

            //if the word is "forward", add the second value to horizontalPosition

            //if the word is "down", add the second value to depth

            //if the word is "up", subtract the second value from depth

            foreach (var line in lines)
            {
                string[] parts;
                parts = line.Split(' ');
                var intPart = int.Parse(parts[1]);
                if (parts[0] == "forward")
                {
                    horizontalPosition += intPart;
                }
                else if (parts[0] == "down")
                {
                    depth += intPart;
                }
                else if (parts[0] == "up")
                {
                    depth -= intPart;
                }
                else
                {
                    //Note: this should NOT happen
                    Console.WriteLine($"Unknown direction {parts[0]}");
                }
            }

            Console.WriteLine($"Horizontal position and depth together are {horizontalPosition * depth}");
        }

        public static void DoDay2Part2()
        {
            Console.WriteLine("In Day 2, Part 2");

            var lines = ReadDay2PrimeFile();

            if (lines == null)
            {
                Console.WriteLine("Day 2 Prime file is empty");
                return;
            }

            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;

            foreach (var line in lines)
            {
                string[] parts;
                parts = line.Split(' ');
                var intPart = int.Parse(parts[1]);
                if (parts[0] == "forward")
                {
                    horizontalPosition += intPart;
                    depth += (aim * intPart);
                }
                else if (parts[0] == "down")
                {
                    aim += intPart;
                }
                else if (parts[0] == "up")
                {
                    aim -= intPart;
                }
                else
                {
                    //Note: this should NOT happen
                    Console.WriteLine($"Unknown direction {parts[0]}");
                }

                if (aim < 0)
                {
                    //it doesn't make sense that the submarine could be above water
                    aim = 0;
                }
            }

            Console.WriteLine($"Horizontal position and depth together are {horizontalPosition * depth}");
        }

        public static string[]? ReadDay2PrimeFile()
        {
            // inspired by: https://stackoverflow.com/questions/13762338/read-files-from-a-folder-present-in-project
            string executionPath = Environment.CurrentDirectory;
            var path = executionPath + @"\Data\Day2Prime.txt";

            //Ingest the Day 2 Prime data

            return File.ReadAllLines(path);
        }

    }
}
