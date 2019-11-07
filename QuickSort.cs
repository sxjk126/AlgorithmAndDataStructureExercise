using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructureExercise
{
    public class QuickSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] arr)
        {
            SortHelper(arr, 0, arr.Length - 1);
        }
        private static void SortHelper(T[] arr, int start, int end)
        {
            //if we have at least two elements in the array
            if (start < end)
            {
                //choose a pivot
                int pivotPos = PartitionRandomly(arr, start, end);
                SortHelper(arr, start, pivotPos - 1); //recursively sort values less than pivot
                SortHelper(arr, pivotPos + 1, end); //recursively sort values more than pivot
            }
        }
        private static int Partition(T[] arr, int start, int end)
        {
            //Select the last value as one pivot value in array
            T pivot = arr[end];
            int k = start - 1;
            for (int i = start; i < end; i++)
            {
                if (arr[i].CompareTo(pivot) < 0)
                { 
                    k++;
                    //swap arr[k] with arr[i]
                    Swap<T>(ref arr[k], ref arr[i]);
                }
            }
            //move the pivot in place
            T temp = arr[end];
            arr[end] = arr[k + 1];
            arr[k + 1] = temp;
            return k + 1;
        }
        private static int PartitionRandomly(T[] arr, int start, int end)
        {
            //Create a Random object
            Random random = new Random();
            //Generate a random item in the array
            //T rand = arr[random.Next(start, end + 1)]; //maximum value in Next() is exclusive
            Swap<T>(ref arr[random.Next(start, end + 1)], ref arr[end]);
            return Partition(arr, start, end);
        }
        private static void Swap<C>(ref C a, ref C b)
        {
            C temp = a;
            a = b;
            b = temp;
        }
    }
}
