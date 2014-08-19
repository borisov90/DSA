namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SortSequence;
    using CalculatingSequence;
    
    public class LongestSubsequence
    {
        /// <summary>
        /// Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>.
        /// Write a program to test whether the method works correctly.
        /// </summary>
        static void Main()
        {
            var listOfNumbers = Lister.GetList();
            var sortedList = listOfNumbers.OrderBy(x => x).ToList();
            /*this would not work if the list isn't sorted*/
            var longestSequence = Finder.findLongestSubsequence(sortedList);
            Printer.printCollection(longestSequence);
        }
    }
}
