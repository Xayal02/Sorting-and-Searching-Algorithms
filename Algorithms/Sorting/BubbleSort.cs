using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{
    internal class BubbleSort
    {
        public static void BubbleSortAlgorithm(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Compare adjacent elements and swap if necessary
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
