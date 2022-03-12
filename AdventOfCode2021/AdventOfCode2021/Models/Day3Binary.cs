namespace AdventOfCode2021.Models
{
    public class Day3Binary
    {
        int numOf1;
        int numOf0;

        public Day3Binary()
        {
            numOf0 = 0;
            numOf1 = 0;
        }

        /// <summary>
        /// This takes either a char value of '0' or a char value of '1'. No other values are valid.
        /// If it's a 0, then it adds 1 to the number of times '0' has been added. Otherwise
        /// it will consider the value passed to be '1', then will increment the number of '1' passed 
        /// to it
        /// </summary>
        /// <param name="BitToAdd">Either '0' or '1'</param>
        public void AddBit(char BitToAdd)
        {
            if (BitToAdd == '0')
            {
                numOf0++;
            }
            else
            {
                numOf1++;
            }
        }

        /// <summary>
        /// Returns whichever bit occurred most often of all the values passed to this
        /// routine.
        /// </summary>
        /// <returns>The most frequent value</returns>
        public string MostCommonBit()
        {
            if (numOf0 > numOf1)
            {
                return "0";
            }
            return "1";
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
