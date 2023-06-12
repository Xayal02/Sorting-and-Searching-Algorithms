using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{
    internal class RadixSort
    {
        public static void RadixSortAlgorithm(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            int max = GetMaxValue(arr);

            // Perform counting sort for each digit position
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(arr, exp);
            }
        }

        private static int GetMaxValue(int[] arr)
        {

            
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        private static void CountingSort(int[] arr, int exp)
        {
            int initialArrayLength = arr.Length;
            int[] output = new int[arr.Length];
            int[] count = new int[10]; // 10 is the number of possible digits (0-9)

            // Store the count of each digit in the count array
            for (int i = 0; i < initialArrayLength; i++)
            {
                int digit = arr[i] / exp % 10;
                count[digit]++;
            }

            // Modify the count array to store the actual position of each digit
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Build the output array by placing each element in its correct position
            for (int i = initialArrayLength - 1; i >= 0; i--)
            {
                int digit = arr[i] / exp % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            // Copy the sorted elements from the output array to the original array
            Array.Copy(output, arr, initialArrayLength);
        }
    }
}
