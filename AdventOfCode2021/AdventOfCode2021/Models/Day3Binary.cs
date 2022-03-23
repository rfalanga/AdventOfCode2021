namespace AdventOfCode2021.Models
{
    public class Day3Binary : Day3BinaryBase
    {
        /// <summary>
        /// Returns whichever bit occurred most often of all the values passed to this
        /// routine.
        /// </summary>
        /// <returns>The most frequent value</returns>
        public string MostCommonBit()
        {
            if (numOf1s >= numOf0s)
            {
                return "1";
            }
            return "0";
        }

        /// <summary>
        /// Returns the least common bit of all values passed to this routine
        /// </summary>
        /// <returns>Returns least common bit</returns>
        public string LeastCommonBit()
        {
            if (MostCommonBit() == "0")
            {
                return "1";
            }
            return "0";
        }
    }
}
