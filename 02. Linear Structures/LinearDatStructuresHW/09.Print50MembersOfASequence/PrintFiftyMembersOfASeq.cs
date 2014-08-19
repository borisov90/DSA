namespace PrintFiftyMembersOfASeq
{
    using CalculatingSequence;
    using SortSequence;
    using System;
    using System.Collections.Generic;

    public class PrintFiftyMembersOfASeq
    {
        /// <summary>
        /// We are given the following sequence:
        /// S1 = N;
        /// S2 = S1 + 1;
        /// S3 = 2*S1 + 1;
        /// S4 = S1 + 2;
        /// S5 = S2 + 1;
        /// S6 = 2*S2 + 1;
        /// S7 = S2 + 2;
        /// ...
        /// 
        /// Using the Queue<T> class write a program to print its first 50 members for given N.
        /// Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
        /// </summary>
        public static void Main()
        {
            const string welcomeMessage = "Enter number, please!";
            Console.WriteLine(welcomeMessage);
            var inputN = Reader.readIntegeFromConsole();
            var processedSequence = Processer.ProcessSequence(inputN);
            Printer.printCollection(processedSequence);
        }
    }
}
