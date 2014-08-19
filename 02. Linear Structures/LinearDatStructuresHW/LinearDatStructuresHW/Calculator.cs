namespace CalculatingSequence
{
    using System;
    using System.Collections.Generic;
    
    public class Calculator
    {
        public static int calculateSum(IList<int> sequence)
        {
            int index;
            var sequenceLength = sequence.Count;
            var sum = 0;
            for (index = 0; index < sequenceLength; index++)
            {
                sum += sequence[index];
            }

            return sum;
        }
        public static int calculateAverage(IList<int> sequence)
        {
            var sequenceLength = sequence.Count;
            var sum = calculateSum(sequence);
            var average = sum / sequenceLength;

            return average;
        }
    }
}
