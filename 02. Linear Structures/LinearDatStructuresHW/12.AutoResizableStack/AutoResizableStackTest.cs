namespace AutoResizableStack
{
    using System;
    using System.Collections.Generic;
    public class AutoResizableStackTest
    {
        static void Main()
        {
            AutoResizableStack<int> stack = new AutoResizableStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Pop();

            Console.WriteLine("Stack.Count = " + stack.Count);

            Console.WriteLine("Stack.Peek() = " + stack.Peek());

            Console.Write("Print Stack.ToArray() - > ");
            int[] array = stack.ToArray();

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Test TrimExcess()");

            //put a breakpoint in TrimExcess return value
            stack.TrimExcess();
            //check using stack after TrimEcess()
            stack.Push(4);


            Stack<int> num = new Stack<int>();
        }
    }
}

