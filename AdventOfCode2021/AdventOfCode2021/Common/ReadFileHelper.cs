namespace AdventOfCode2021.Common
{
    // I should have done this at the beginning.
    public static class ReadFileHelper
    {
        /// <summary>
        /// This is the routine that will read through the Advent of Code files. It reads the passed file, then 
        /// this constructs the the full path to the file and opens it, reads all the contents and returns 
        /// the contents as a nullable string[]. The file MUST be in the Data folder
        /// </summary>
        /// <param name="TextFileName">The name of the text file, for example: Day1.txt </param>
        /// <returns>A nullable string array which is the contents of the file passed to this routine</returns>
        public static string[]? ReadTextFileReturnContents(string TextFileName)
        {
            // inspired by: https://stackoverflow.com/questions/13762338/read-files-from-a-folder-present-in-project
            string executionPath = Environment.CurrentDirectory;
            var path = executionPath + @"\Data\" + TextFileName;

            // read in the contents of the text file, returning the contents to the calling routine
            return File.ReadAllLines(path);
        }
    }
}
