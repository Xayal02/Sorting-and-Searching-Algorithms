using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{
    internal class BucketSort
    {
        public static void BucketSortAlgorithm(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            int n = arr.Length;

            // Find the maximum and minimum values in the array
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }

            // Create a list of empty buckets
            List<int>[] buckets = new List<int>[n];

            // Initialize each bucket as an empty list
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<int>();
            }

            // Assign each element to the appropriate bucket
            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (arr[i] - min) * (n - 1) / (max - min);
                buckets[bucketIndex].Add(arr[i]);
            }

            // Sort each bucket individually using a sorting algorithm (here, Insertion Sort is used)
            for (int i = 0; i < n; i++)
            {
                InsertionSort(buckets[i]);
            }

            // Concatenate the sorted buckets into the original array
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                foreach (int num in buckets[i])
                {
                    arr[index] = num;
                    index++;
                }
            }
        }

        private static void InsertionSort(List<int> bucket)
        {
            for (int i = 1; i < bucket.Count; i++)
            {
                int key = bucket[i];
                int j = i - 1;
                while (j >= 0 && bucket[j] > key)
                {
                    bucket[j + 1] = bucket[j];
                    j--;
                }
                bucket[j + 1] = key;
            }
        }

    }

}
