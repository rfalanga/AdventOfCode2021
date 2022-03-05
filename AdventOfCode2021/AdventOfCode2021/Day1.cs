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

            // inspired by this link: https://stackoverflow.com/questions/13762338/read-files-from-a-folder-present-in-project
            string executionPath = Environment.CurrentDirectory;
            var path = executionPath + @"\Data\Day1.txt";

            //Ingest the Day 1 data
            using (FileStream fs = File.Open(@"Data\Day1.txt", FileMode.Open))
            {
                int i = 1;
            }

        }
    }
}
