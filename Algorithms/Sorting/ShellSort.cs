using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{
    internal class ShellSort
    {
        public static void ShellSortAlgorithm(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            int n = arr.Length;

            // Start with a large gap and reduce it in each iteration
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Perform insertion sort for elements at each gap distance
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;

                    // Shift elements that are greater than the current element to the right
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }
            }
        }
    }
}
