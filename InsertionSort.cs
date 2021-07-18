using System;

namespace SortingAlgorithms
{
    static partial class Program
    {
        static void InsertionSort(int[] arr)
        {
            int j;
            for (int i = 1; i < arr.Length; i++)
            {
                j = 1;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }

            Console.WriteLine("\nArray after insertion sort:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
    }
}
