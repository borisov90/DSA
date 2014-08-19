namespace RemoveNegativeNums
{
    using System.Collections.Generic;
    using System.Linq;
    public class Remover
    {
        public static IList<int> removeNegativeNumbers(IList<int> sequence)
        {
            int index;
            var sequenceLength = sequence.Count;
            var sequenceWithoutNegativeNums = new List<int>();
            
            for (index = 0; index < sequenceLength; index++)
            {
                if (sequence[index] > 0)
                {
                    sequenceWithoutNegativeNums.Add(sequence[index]);
                }
                else
                {
                    continue;
                }
            }
            return sequenceWithoutNegativeNums;
        }
        public static IList<int> removeOddOccurencies(List<int> sequence)
        {
            var dictionary = new Dictionary<int, int>();
            var sequenceLength = sequence.Count;
            int index;

            for (index = 0; index < sequenceLength; index++)
            {
                if (dictionary.ContainsKey(sequence[index]))
                {
                    dictionary[sequence[index]]++;
                }
                else
                {
                    dictionary.Add(sequence[index], 1);
                }
            }

            /*If the value of the key in the dictionary is not prime, it is removed*/
            sequence.RemoveAll(x => dictionary[x] % 2 != 0);

            return sequence;
        }
    }
}
