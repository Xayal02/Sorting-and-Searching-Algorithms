using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Searching
{
    internal class LinearSearch
    {
        public static int LinearSearchAlgorithm(int[] arr, int target)
        {
            if (arr == null || arr.Length == 0)
                return -1;

            int n = arr.Length;

            // Iterate through the array and compare each element with the target
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == target)
                    return i; // Return the index if the target is found
            }

            return -1;
        }
    }
}
