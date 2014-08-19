namespace PseudoLinkedList
{
    using System;
    using System.Collections.Generic;

    public class PseudoTest
    {
        /// <summary>
        /// Implement the data structure linked list. Define a class ListItem<T> that has two fields:
        /// value (of type T) and NextItem (of type ListItem<T>).
        /// Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
        /// </summary>
        static void Main()
        {
            var linked = new PseudoLinkedList<int>();

            linked.AddLast(19);

            linked.AddFirst(15);
            linked.AddFirst(14);
            linked.AddFirst(100);
            linked.AddFirst(11);

            linked.AddLast(50);

            Console.WriteLine("LinkedList.Count = " + linked.Count);

            linked.PrintList();

            Console.WriteLine("After removing elements");
            linked.Remove(3);
            linked.Remove(14);
            linked.PrintList();
        }
    }
}
