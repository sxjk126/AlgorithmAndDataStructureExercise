using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructureExercise
{
    /// <summary>
    /// A linear search library which implementing linear search algorithm.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinearSearch
    {
        /// <summary>
        /// A search method implementing linear search algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values">This is the Array you looking at</param>
        /// <param name="target">This is the value you looking for</param>
        /// <returns>Return the index of target value, if not found return -1.</returns>
        public static int Search<T>(T[] values, T target)
        {
            //initialize the target index to -1 and means we have not find the target value yet
            int targetIndex = -1;
            //Traverse the array
            for (int i = 0; targetIndex == -1 && i < values.Length; i++)
            {
                if (Object.Equals(values[i], target))
                {
                    targetIndex = i;
                }
            }
            return targetIndex;
        }
    }
}
