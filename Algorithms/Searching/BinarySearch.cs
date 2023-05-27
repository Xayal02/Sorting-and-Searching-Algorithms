namespace Sorting_and_Searching_Algorithms.Algorithms.Searching
{
    public class BinarySearchExample
    {
        public static int BinarySearch(int[] arr, int target)
        {

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                // If the target is found at the middle index, return it
                if (arr[mid] == target)
                    return mid;

                // If the target is greater, ignore the left half
                if (arr[mid] < target)
                    left = mid + 1;

                // If the target is smaller, ignore the right half
                else
                    right = mid - 1;
            }

            // If the target is not found, return -1
            return -1;
        }
    }
}