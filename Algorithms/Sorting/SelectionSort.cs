using Algorithms;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{
    internal partial class SelectionSort
    {
        public static void SelectionSortAlgorithm(int[] arr)
        {
            if(arr is null) return;

            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element

                Program.Swap(arr, minIndex, i);
            }
        }
    }
}
