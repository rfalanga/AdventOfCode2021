namespace AdventOfCode2021.Models
{
    public class Day3LifeSupportRating : Day3BinaryBase
    {
        /// <summary>
        /// Returns the most common value (0 or 1) in the current bit position.
        /// If the number of 1's is greater than the number of 0's, then return "1".
        /// If the number of 0's is greater than the number of 1's, then return "0".
        /// If they are equal, then return "1".
        /// </summary>
        /// <returns></returns>
        public string OxygenGeneratorRating()
        {
            if (numOf1s > numOf0s)
            {
                return "1";
            }
            else if (numOf1s < numOf0s)
            {
                return "0";
            }

            return "1";
        }

        /// <summary>
        /// Returns the least common value (0 or 1) in the current bit position.
        /// If the number of 1's is greater than the number of 0's, then return "1".
        /// If the number of 0's is greater than the number of 1's, then return "0".
        /// If they are equal, then return "0".
        /// </summary>
        /// <returns></returns>
        public string CO2ScrubberRating()
        {
            if (numOf1s > numOf0s)
            {
                return "0";
            }
            else if (numOf1s < numOf0s)
            {
                return "1";
            }

            return "0";
        }
    }
}
