namespace PrintFiftyMembersOfASeq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Processer
    {
        public static IList<int> ProcessSequence(int number)
        {
            int limit = 50;
            int count;
            var sequence = new Queue<int>();
            var finalList = new List<int>();
            sequence.Enqueue(number);
            for (count = 0; count < limit; count++)
            {
                int current = sequence.Dequeue();
                finalList.Add(current);
                sequence.Enqueue(current + 1);
                sequence.Enqueue(2 * current + 1);
                sequence.Enqueue(current + 2);
            }

            return finalList;
        }
    }
}
