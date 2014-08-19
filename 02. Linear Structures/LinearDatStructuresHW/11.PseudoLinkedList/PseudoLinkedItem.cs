namespace PseudoLinkedList
{
    using System;
    public class PseudoLinkedItem<T>
    {
        public T Value { get; set; }
        public PseudoLinkedItem<T> NextItem { get; set; }

        public PseudoLinkedItem(T data)
        {
            this.Value = data;
        }
    }
}
