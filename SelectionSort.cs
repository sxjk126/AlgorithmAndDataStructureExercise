using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructureExercise
{
    public class SelectionSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                int minPos = i; //hold the position for min value
                for (int j = i + 1; j < values.Length; j++) //search for smallest value
                {
                    if (values[minPos].CompareTo(values[j]) > 0)
                    {
                        minPos = j;
                    }
                }
                //at the end of this loop we found the smallest value
                //swap the smallest value with first value
                T tmp = values[i];
                values[i] = values[minPos];
                values[minPos] = tmp;
            }
        }
    }
}
