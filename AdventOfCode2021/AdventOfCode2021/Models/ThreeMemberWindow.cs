using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Models
{
    /// <summary>
    /// This class is to assist with Day 2. It will maintain the state in an array[3] of values added 
    /// to it. Reporting the sum, once the elements have all been applied. Also, when adding new elements
    /// to this class, it will handle where they should go within the array, replacing the oldest first.
    /// </summary>
    public class ThreeMemberWindow
    {
        readonly int[] localArray;
        int nextIndex;

        public ThreeMemberWindow()
        {
            nextIndex = 0;
            localArray = new int[3];
        }

        /// <summary>
        /// This method handles the private array, where to place the new value
        /// </summary>
        /// <param name="NewValue">int value to add to private array</param>
        public void Add(int NewValue)
        {
            localArray[nextIndex++] = NewValue;
            nextIndex = nextIndex % 3;
        }

        /// <summary>
        /// This will return the sum of all values in the array, so long as the local array is
        /// fully populated. Otherwise, it returns -1.
        /// </summary>
        /// <returns>Sum of all values when fully populated</returns>
        public int Sum()
        {
            if (localArray.Contains(0))
            {
                return -1;
            }
            else
            {
                return localArray.Sum();
            }
        }
    }
}
