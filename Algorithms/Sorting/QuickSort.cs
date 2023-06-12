using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{
    internal class QuickSort
    {
        public static void QuickSortAlgorithm(int[] arr)
        {
            QuickSortAlgorithm(arr, 0, arr.Length - 1);
        }

        private static void QuickSortAlgorithm(int[] arr, int low, int high)
         {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSortAlgorithm(arr, low, pivotIndex - 1);
                QuickSortAlgorithm(arr, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Program.Swap(arr, i, j);
                }
            }

            Program.Swap(arr, i + 1, high);
            return i + 1;
        }


    }
}
