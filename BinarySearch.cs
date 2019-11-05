using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructureExercise
{
    class BinarySearch<T> where T : IEquatable<T>, IComparable<T>
    {
        public static int Search(T[] values, T target)
        {
            int start = 0;
            int end = values.Length - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (values[middle].Equals(target))
                {
                    return middle;
                }
                else if (values[middle].CompareTo(target) > 0)
                {
                    end = middle - 1;
                }
                else // if(values[middle].CompareTo(target) < 0)
                {
                    start = middle + 1;
                }
            }
            return -1;
        }
    }
}
