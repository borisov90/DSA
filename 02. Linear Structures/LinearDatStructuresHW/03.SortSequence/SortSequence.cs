namespace SortSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CalculatingSequence;
    public class SortSequence
    {
        /// <summary>
        /// Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
        /// </summary>
        public static void Main()
        {
            var listOfNumbers = Lister.GetList();
            var sortedList = listOfNumbers.OrderBy(x => x).ToList();
            Printer.printCollection(sortedList);
        }
    }
}
