using System;

namespace SortingAlgorithms
{
    static partial class Program
    {
        static void QuickSort(int[] arr, int left, int right)
        {
            int l = left;
            int r = right - 1;
            int size = right - left;

            if (size > 1)
            {
                Random rand = new();
                int pivot = arr[rand.Next(0, size) + l];

                while (l < r)
                {
                    while (arr[r] > pivot && l <= r)
                    {
                        r--;
                    }

                    while (arr[l] < pivot && l <= r)
                    {
                        l++;
                    }

                    if (l < r)
                    {
                        int temp = arr[l];
                        arr[l] = arr[r];
                        arr[r] = temp;
                        l++;
                    }
                }
                QuickSort(arr, left, l);
                QuickSort(arr, r, right);
            }
        }
    }
}
