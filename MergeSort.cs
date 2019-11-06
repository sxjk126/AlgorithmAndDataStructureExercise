using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructureExercise
{
    public class MergeSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] values)
        {
            T[] temp = new T[values.Length];
            SortHelper(values, 0, values.Length - 1, temp);
        }
        public static void SortHelper(T[] arr, int start, int end, T[] temp)
        {
            //if we have at least two elements in the subarray
            if (start < end)
            {
                int middle = (start + end) / 2;
                //Recursively sort each half
                SortHelper(arr, start, middle, temp);
                SortHelper(arr, middle + 1, end, temp);
                //Merge the two halves
                Merge(arr, start, middle, middle + 1, end, temp);
            }
        }
        public static void Merge(T[] arr, int startA, int endA, int startB, int endB, T[] temp)
        {
            int i = startA;
            int j = startB;
            int k = startA;

            while (i <= endA && j <= endB)
            {
                if (arr[i].CompareTo(arr[j]) <= 0)
                {
                    temp[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                    k++;
                }
            }
            //copy the left over values
            while (i <= endA)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }
            while (j <= endB)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }
            //push back temp into arr
            for (k = startA; k <= endB; k++)
            {
                arr[k] = temp[k];
            }
        }
    }
}
