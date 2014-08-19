namespace DynamicLinkedQueue
{
    using System;
    using System.Collections.Generic;

    public class DynamicLinkedQueue<T>
    {
        private LinkedList<T> linkedList;

        public DynamicLinkedQueue()
        {
            this.linkedList = new LinkedList<T>();
        }

        public int Count
        {
            get
            {
                return this.linkedList.Count;
            }
        }

        public void Enqueue(T value)
        {
            this.linkedList.AddFirst(value);
        }

        public void Dequeue()
        {
            if (this.linkedList == null)
            {
                throw new ArgumentNullException("You can't remove element from empty list");
            }

            this.linkedList.RemoveFirst();
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new ArgumentException("Queue is empty");
            }

            return this.linkedList.First.Value;
        }

        public void Clear()
        {
            this.linkedList.Clear();
        }

        public void PrintList()
        {
            foreach (var item in linkedList)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
