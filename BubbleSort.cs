using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructureExercise
{
    public class BubbleSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //set wasSwapped to false
                bool wasSwapped = false;
                for (int j = 0; j < arr.Length - 1- i; j++)
                {
                    
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                        wasSwapped = true;
                    }
                   
                }
                //if traverse one time and everthing is sorted, return
                if (!wasSwapped)
                {
                    return;
                }
            }
        }
    }
}
