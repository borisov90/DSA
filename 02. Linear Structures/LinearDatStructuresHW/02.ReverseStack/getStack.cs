namespace ReversingStack
{
    using System;
    using System.Collections.Generic;
    using CalculatingSequence;

    public class Stacker
    {
        public static Stack<int> GetStack() 
        {
            Console.WriteLine("How many numbers would you like to enter?");
            var numbersCount = Reader.readFromConsole();
            Console.WriteLine("Okay, proceed then!");
            var theStack = new Stack<int>();

            int count;
            for (count = 0; count < int.Parse(numbersCount); count++)
            {

                try
                {
                    var line = Reader.readFromConsole();
                    theStack.Push(Validator.validateInput(line));
                }
                catch (Exception)
                {

                    ExceptionHandler.sendInteligentException();
                }
            }
            return theStack;
        }
    }
}
