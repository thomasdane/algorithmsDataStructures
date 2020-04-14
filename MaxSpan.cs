using System;
using System.Collections.Generic;
using System.Text;

/*

Consider the leftmost and righmost appearances of some value in an array. 
We'll say that the "span" is the number of elements between the two inclusive. 
A single value has a span of 1. Returns the largest span found in the given array. 
(Efficiency is not a priority.)

maxSpan([1, 2, 1, 1, 3]) → 4
maxSpan([1, 4, 2, 1, 4, 1, 4]) → 6
maxSpan([1, 4, 2, 1, 4, 4, 4]) → 6

*/

namespace algorithmsDataStructures
{
    class MaxSpan
    {
        public static int Run(List<int> input)
        {
            int result = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int firstIndex = i;

                int lastIndex = i;

                for (int j = i; j < input.Count; j++)
                {
                    if (input[j] == input[i])
                    {
                        lastIndex = j;
                    }
                }

                int span = lastIndex - firstIndex + 1;

                if (span > result) result = span;
            }

            return result;
        }
    }
}
