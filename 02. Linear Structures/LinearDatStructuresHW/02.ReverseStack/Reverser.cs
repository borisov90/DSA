namespace ReversingStack
{
    using System;
    using System.Collections.Generic;
    using CalculatingSequence;
    public class Reverser
    {
        public static void ReverseStack(Stack<int> stack)
        {
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
