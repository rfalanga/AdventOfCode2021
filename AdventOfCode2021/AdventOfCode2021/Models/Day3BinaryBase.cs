using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Models
{
    public class Day3BinaryBase : IDay3Binary
    {
        protected int numOf1;
        protected int numOf0;

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
    }
}
