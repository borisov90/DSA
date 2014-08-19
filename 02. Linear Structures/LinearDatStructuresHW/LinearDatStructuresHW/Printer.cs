namespace CalculatingSequence
{
    using System;
    using System.Collections.Generic;

    public class Printer
    {
        public static void printCollection(IList<int> sequence)
        {
            int count;
            var sequenceLength = sequence.Count;
            var printCollectionMessage = "The sequence so far: ";
            Console.Write(printCollectionMessage);

            for (count = 0; count < sequenceLength; count++)
            {
                Console.Write(sequence[count] + " ");
            }
            Console.WriteLine();
        }
        public static void printOccurencies(Dictionary<int, int> dictionary)
        {
            foreach (KeyValuePair<int, int> number in dictionary)
            {
                Console.WriteLine(number.Key.ToString() + " -> " + number.Value.ToString() + "times");
            }
        }
    }
}
