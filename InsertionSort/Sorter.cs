using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array can not be null.");
            }

            int temp;
            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] < temp)
                    {
                        break;
                    }

                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array can not be null.");
            }

            int startIndex = 1;
            while (startIndex < array.Length)
            {
                for (int i = startIndex; i < array.Length; i++)
                {
                    int extract = array[i];
                    int lastSortedIndex = i;
                    bool isСhanged = false;
                    while (lastSortedIndex > 0 && extract < array[lastSortedIndex - 1])
                    {
                        array[lastSortedIndex] = array[lastSortedIndex - 1];
                        lastSortedIndex--;
                        isСhanged = true;
                    }

                    if (isСhanged)
                    {
                        array[lastSortedIndex] = extract;
                        array.RecursiveInsertionSort();
                    }

                    startIndex++;
                }
            }
        }
    }
}
