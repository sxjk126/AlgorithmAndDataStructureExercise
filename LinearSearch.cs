using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructureExercise
{
    class LinearSearch<T>
    {
        public int Search<T>(T[] values, T target)
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
