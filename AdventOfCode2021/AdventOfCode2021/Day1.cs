using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    public static class Day1
    {
        public static void DoDay1()
        {
            Console.WriteLine("In Day1");

            // inspired by: https://stackoverflow.com/questions/13762338/read-files-from-a-folder-present-in-project
            string executionPath = Environment.CurrentDirectory;
            var path = executionPath + @"\Data\Day1.txt";

            //Ingest the Day 1 data
            
            var readLines = File.ReadAllLines(path);

            //now look for increase vs. decrease value
            int compare = -1;
            int numOfIncreases = 0;

            for (int i = 0; i < readLines.Length; i++)
            {
                var line = readLines[i];
                int integerRead = 0;
                if (int.TryParse(line, out integerRead))
                {
                    if (compare == -1)
                    {
                        Console.WriteLine($"{integerRead} (N/A - no previous measurement)");
                    }
                    else
                    {
                        if (compare < integerRead)
                        {
                            Console.WriteLine($"{integerRead} (increased)");
                            numOfIncreases++;
                        }
                        else
                        {
                            Console.WriteLine($"{integerRead} (decreased)");
                        }
                        compare = integerRead;
                    }
                }
            }
        }
    }
}
