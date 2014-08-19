namespace ReversingStack
{
    using System;
    using System.Collections.Generic;
    using CalculatingSequence;

    public class ReverseStack
    {
        /// <summary>
        /// Write a program that reads N integers from the console and reverses them using a stack. 
        /// Use the Stack<int> class.
        /// </summary>
        /// 
        public static void Main()
        {
            var theStack = Stacker.GetStack();
            var theReversedStack = new Stack<int>(theStack);
            
            /* 1 way : When you add item to a stack, it is Poped, that's why when you add a stack to another stack,
            then the first one is automaticaly reverted because it's last item is poped as first in the new Stack. */
            Console.WriteLine("---------- Some funky stuff! ------------");

            foreach (var item in theReversedStack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            /*Another interesting thing here is that when you foreach the Stack, it is printed in original order. Look at the results*/

            Console.WriteLine("---------- My own reverser ------------");

            /* 2 way : You can pop the original Stack yourself*/

            Reverser.ReverseStack(theStack);
            Console.WriteLine();

        }
    }
}
