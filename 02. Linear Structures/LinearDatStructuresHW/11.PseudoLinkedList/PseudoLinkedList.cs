namespace PseudoLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PseudoLinkedList<T>
    {
        public PseudoLinkedItem<T> FirstElement { get; set; }
        public PseudoLinkedItem<T> LastElement { get; set; }
        public PseudoLinkedItem<T> CurrentElement { get; set; }

        public int Count
        {
            get
            {
                return CheckCount();
            }
        }
        public int CheckCount()
        {
            if (FirstElement == null)
            {
                return 0;
            }

            this.CurrentElement = this.FirstElement;

            int counter = 1;
            while (this.CurrentElement.NextItem != null)
            {
                counter++;
                this.CurrentElement = this.CurrentElement.NextItem;
            }

            return counter;
        }
        public void AddFirst(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new PseudoLinkedItem<T>(value);
                this.LastElement = new PseudoLinkedItem<T>(value);
            }
            else
            {
                PseudoLinkedItem<T> item = new PseudoLinkedItem<T>(value);

                item.NextItem = this.FirstElement;
                this.FirstElement = item;
            }
        }
        public void AddLast(T value)
        {
            if (this.LastElement == null)
            {
                this.FirstElement = new PseudoLinkedItem<T>(value);
                this.LastElement = new PseudoLinkedItem<T>(value);
            }
            else
            {
                PseudoLinkedItem<T> item = new PseudoLinkedItem<T>(value);

                this.CurrentElement = this.FirstElement;
                while (this.CurrentElement.NextItem != null)
                {
                    this.CurrentElement = this.CurrentElement.NextItem;
                }

                this.CurrentElement.NextItem = item;
            }
        }

        public void Remove(T value)
        {
            if (this.FirstElement == null)
            {
                throw new ArgumentNullException("You can't remove element from empty list");
            }

            this.CurrentElement = this.FirstElement;
            PseudoLinkedItem<T> listWithElementToRemove = this.CurrentElement;

            while (this.CurrentElement.NextItem != null)
            {
                if ((dynamic)this.CurrentElement.Value == (dynamic)value)
                {
                    listWithElementToRemove = this.CurrentElement.NextItem;

                    this.FirstElement.NextItem = listWithElementToRemove;
                    break;
                }

                this.FirstElement.NextItem = listWithElementToRemove.NextItem;
                this.CurrentElement = this.CurrentElement.NextItem;
            }
        }

        public void PrintList()
        {
            this.CurrentElement = this.FirstElement;

            Console.WriteLine(CurrentElement.Value);

            while (this.CurrentElement.NextItem != null)
            {
                this.CurrentElement = this.CurrentElement.NextItem;
                Console.WriteLine(this.CurrentElement.Value);
            }
        }
    }
}
