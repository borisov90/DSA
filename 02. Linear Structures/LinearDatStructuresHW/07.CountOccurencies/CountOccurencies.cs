namespace CountOccurencies
{
    using System;
    using System.Collections.Generic;
    using SortSequence;
    using CalculatingSequence;
    public class CountOccurencies
    {
        /// <summary>
        /// Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
        /// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        ///2  2 times
        ///3  4 times
        ///4  3 times
        /// </summary>
        public static void Main()
        {
            var arrayOfNumbers = Lister.getArray();
            var numberOfOccurencies = Counter.CountOccurencies(arrayOfNumbers);
            Printer.printOccurencies(numberOfOccurencies);
        }
    }
}
