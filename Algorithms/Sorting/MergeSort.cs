using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{
    internal class MergeSort
    {
        public static void MergeSortAlgorithm(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return;

            int n = arr.Length;
            int mid = n / 2;

            // Create two temporary arrays
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            // Copy elements to the temporary arrays
            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, n - mid);

            // Recursive calls to sort the two halves
            MergeSortAlgorithm(left);
            MergeSortAlgorithm(right);

            // Merge the sorted halves
            Merge(arr, left, right);


        }

        public static void Merge(int[] arr, int[] left, int[] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int i = 0, j = 0, k = 0;

            // Merge the two halves while comparing elements
            while (i < leftLength && j < rightLength)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copy the remaining elements from the left half
            while (i < leftLength)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            // Copy the remaining elements from the right half
            while (j < rightLength)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
