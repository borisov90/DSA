namespace CalculatingSequence
{
    using System;
    using System.Collections.Generic;
    
    public class EntryPoint
    {
        /// <summary>
        /// Write a program that reads from the console a sequence of positive integer numbers. 
        /// The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence.
        /// Keep the sequence in List<int>.
        /// </summary>
        public static void Main()
        {
             const string endCommand = "";
             const string welcomingMessage = "Please, enter some numbers. Each of them should be on another row. Send empty line when you are done.";
             Console.WriteLine(welcomingMessage);
             var line = Reader.readFromConsole();
             var sequence = new List<int>();
             while (line != endCommand)
             {
                 try
                 {
                     sequence.Add(Validator.validateInput(line));
                     Printer.printCollection(sequence);
                     line = Reader.readFromConsole();
                 }
                 catch (Exception)
                 {

                     ExceptionHandler.sendInteligentException();
                     line = Reader.readFromConsole();
                 }
             }
             Printer.printCollection(sequence);
             Console.WriteLine("The sum of the numbers is " + Calculator.calculateSum(sequence));
             Console.WriteLine("The average numbers is " + Calculator.calculateAverage(sequence));
            
        }
    }
}
