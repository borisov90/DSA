namespace RemoveNegativeNums
{
    using System.Collections.Generic;
    using System.Linq;
    using CalculatingSequence;
    using SortSequence;

    public class RemoveNegativeNums
    {
        /// <summary>
        /// Write a program that removes from given sequence all negative numbers.
        /// </summary>
        static void Main()
        {
            var listOfNumbers = Lister.GetList();
            var listWithoutNegativeNums = Remover.removeNegativeNumbers(listOfNumbers);
            Printer.printCollection(listWithoutNegativeNums);
        }
    }
}
