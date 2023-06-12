using Sorting_and_Searching_Algorithms.Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Sorting_and_Searching_Algorithms.Algorithms.Sorting.SelectionSort;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
          //You can test algorithms here
        }
        private static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        //This method is used throughout the project
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}

