namespace LongestSubsequence
{
    using System.Collections.Generic;
    public class Finder
    {
        public static IList<int> findLongestSubsequence(IList<int> sequence) 
        {
            int index;
            var sequenceLength = sequence.Count;
            var longestSequence = 1;
            var currentSequence = 1;
            var itemIndex = 0;

            for (index = 1; index < sequenceLength; index++)
            {
                if (sequence[index] == sequence[index - 1])
                {
                    currentSequence++;
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        itemIndex = index;
                    }
                    
                }
                else
                {
                    currentSequence = 1;
                }
            }

            return fillSequence(longestSequence, itemIndex, sequence);
        }
        private static IList<int> fillSequence(int sequenceLength, int sequenceIndex, IList<int> sequence)
        {
            var filledSequence = new List<int>();
            for (int i = 0; i < sequenceLength; i++)
            {
                filledSequence.Add(sequence[sequenceIndex]);
            }

            return filledSequence;
        }
    }
}
