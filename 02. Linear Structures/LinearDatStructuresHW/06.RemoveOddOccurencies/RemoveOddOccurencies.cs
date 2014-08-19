namespace RemoveOddOccurencies
{
    using CalculatingSequence;
    using RemoveNegativeNums;
    using SortSequence;
    using System.Collections.Generic;

    public class RemoveOddOccurencies
    {
        /// <summary>
        /// Write a program that removes from given sequence all numbers that occur odd number of times. 
        /// </summary>
        public static void Main()
        {
            var listOfNumbers = Lister.GetList();
            var listWithoutOddOccurencies = Remover.removeOddOccurencies(listOfNumbers);
            Printer.printCollection(listWithoutOddOccurencies);
        }
    }
}
