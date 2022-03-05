namespace AdventOfCode2021
{
    public static class Day1
    {
        public static void DoDay1()
        {
            Console.WriteLine("In Day1");

            var readLines = ReadDay1File();

            if (readLines == null)
            {
                Console.WriteLine("Day1 data file had no data");
                return;
            }

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
                    }

                    compare = integerRead;
                }
            }

            Console.WriteLine($"The number of depth measurement increases from the previous measurement is {numOfIncreases}");
        }

        public static string[]? ReadDay1File()
        {
            // inspired by: https://stackoverflow.com/questions/13762338/read-files-from-a-folder-present-in-project
            string executionPath = Environment.CurrentDirectory;
            var path = executionPath + @"\Data\Day1.txt";

            //Ingest the Day 1 data

            return File.ReadAllLines(path);
        }
    }
}
