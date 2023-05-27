using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{
    internal class CountingSort
    {
        public static void CountingSortAlgorithm(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            int n = arr.Length;

            // Find the maximum element in the array
            int max = ArrayMaxElementDeterminer(arr);

            // Create a count array to store the count of each element
            int[] count = new int[max + 1];

            // Store the count of each element in the count array
            for (int i = 0; i < n; i++)
            {
                count[arr[i]]++;
            }

            // Modify the count array to store the actual position of each element
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }

            // Create a temporary output array
            int[] output = new int[n];

            // Build the output array by placing each element in its correct position
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            // Copy the sorted elements from the output array to the original array
            Array.Copy(output, arr, n);
        }
        private static int ArrayMaxElementDeterminer(int[] arr)
        {
            int maxElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement) maxElement = arr[i];
            }

            return maxElement;
        }


    }
}
