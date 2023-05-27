using Sorting_and_Searching_Algorithms.Algorithms.Sorting;
using System;
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //practise any algorithm here

            int[] nums = { 63, 5, 2, 4, 6, 7, 9, 2, 3, 5 };

            BucketSort.BucketSortAlgorithm(nums);

            PrintArray(nums);
        }
        private static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

       
        
    }
}

