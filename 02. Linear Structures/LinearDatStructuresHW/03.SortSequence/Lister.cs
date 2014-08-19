namespace SortSequence
{
    using System;
    using System.Collections.Generic;
    using CalculatingSequence;
    using System.Linq;
    public class Lister
    {
        public static List<int> GetList()
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
                    line = Reader.readFromConsole();
                }
                catch (Exception)
                {

                    ExceptionHandler.sendInteligentException();
                    line = Reader.readFromConsole();
                }
            }
            return sequence;
        }
        public static int[] getArray()
        {
            const string welcomingMessage = "Please, enter some numbers on a single line, and then press enter!";
            string input;
            var array = new string[] { };

            Console.WriteLine(welcomingMessage);
            
            try
            {
                input = Reader.readFromConsole();
                array = input.Split(new Char[] { ',', ' ', '.' });
            }
            catch (Exception)
            {
                ExceptionHandler.sendInteligentException();
                input = Reader.readFromConsole();
                array = input.Split(new Char[] { ',', ' ', '.' });
            }

            /*Neat way of parsing from one type of array to another*/
            var arrayOfInts = Array.ConvertAll(array, int.Parse);

            return arrayOfInts;
        }
    }
}
