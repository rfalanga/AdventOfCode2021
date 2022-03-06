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
            //Should this be Day 3?
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
