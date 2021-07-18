using System;

namespace SortingAlgorithms
{
    static partial class Program
    {
        static void SelectionSort(int[] arr)
        {
            for (int k = 0; k < arr.Length - 1; k++)
            {
                int min_index = k;
                for (int j = k + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }

                    int temp = arr[min_index];
                    arr[min_index] = arr[k];
                    arr[k] = temp;
                }
            }

            Console.WriteLine("\nArray after selection sort:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
    }
}
