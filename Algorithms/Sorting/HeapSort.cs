using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{ //HeapSortAlgorithm
    internal class HeapSort
    {
        public static void HeapSortAlgorithm(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            // Build max heap from the input array
            BuildMaxHeap(arr);

            // Perform heap sort
            for (int i = arr.Length - 1; i > 0; i--)
            {
                // Swap the root (maximum value) with the last unsorted element
                Swap(arr, 0, i);

                // Maintain the max heap property on the reduced heap
                Heapify(arr, i, 0);
            }
        }

        private static void BuildMaxHeap(int[] arr)
        {
            int n = arr.Length;

            // Start from the last non-leaf node and heapify each node in reverse order
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
        }

        private static void Heapify(int[] arr, int n, int root)
        {
            int largest = root;
            int leftChild = 2 * root + 1;
            int rightChild = 2 * root + 2;

            // Find the largest element among the root and its children
            if (leftChild < n && arr[leftChild] > arr[largest])
                largest = leftChild;

            if (rightChild < n && arr[rightChild] > arr[largest])
                largest = rightChild;

            // If the largest element is not the root, swap them and recursively heapify the affected subtree
            if (largest != root)
            {
                Swap(arr, root, largest);
                Heapify(arr, n, largest);
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

