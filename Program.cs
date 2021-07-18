using System;

namespace SortingAlgorithms
{
    static partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array:");
            int size = int.Parse(Console.ReadLine());
            Random random = new();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            Console.WriteLine("Initial array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }

            while (true)
            {
                Console.WriteLine("\nChoose option:\n" +
                    "1:Bubble Sort\n" +
                    "2:Insertion Sort\n" +
                    "3:Selection Sort\n" +
                    "4:Merge Sort\n" +
                    "5:Quick Sort\n" +
                    "6:Clear screen\n" +
                    "7:Exit");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        BubbleSort(array);
                        break;
                    case 2:
                        InsertionSort(array);
                        break;
                    case 3:
                        SelectionSort(array);
                        break;
                    case 4:
                        MergeSort(array, 0, array.Length - 1);

                        Console.WriteLine("\nArray after merge sort:");
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write(array[i] + "\t");
                        }
                        break;
                    case 5:
                        QuickSort(array, 0, array.Length);

                        Console.WriteLine("\nArray after quick sort:");
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write(array[i] + "\t");
                        }
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong option! Try Again");
                        break;

                }
            }

        }
    }
}
