namespace AutoResizableStack
{
    using System;
    using System.Collections.Generic;

    public class AutoResizableStack<T>
    {
        private static readonly int initialStackCapacity = 1;

        private T[] array = new T[initialStackCapacity];
        private int stackCounter = initialStackCapacity;

        private int index = 0;

        public int Count
        {
            get
            {
                return this.index;
            }
        }

        public void Push(T value)
        {
            if (this.Count == this.stackCounter)
            {
                this.stackCounter *= 2;

                T[] doubleSizeArray = new T[stackCounter];

                Array.Copy(this.array, doubleSizeArray, this.index);

                this.array = doubleSizeArray;
            }

            //This case is happening after using TrimExcess()
            if (array.Length < this.stackCounter)
            {
                T[] newArray = new T[stackCounter];

                Array.Copy(this.array, newArray, this.index);

                this.array = newArray;
            }

            this.array[this.index] = value;
            this.index++;
        }

        public void Pop()
        {
            if (this.array == null)
            {
                throw new ArgumentNullException("You cannot remove element from empty stack");
            }

            T[] doubleSizeArray = new T[stackCounter];

            Array.Copy(this.array, doubleSizeArray, this.index - 1);

            this.array = doubleSizeArray;

            this.index--;
        }

        public T Peek()
        {
            return this.array[index - 1];
        }

        public T[] ToArray()
        {
            T[] newArray = new T[this.index];

            Array.Copy(this.array, newArray, this.index);

            this.array = newArray;

            return newArray;
        }

        public void TrimExcess()
        {
            T[] trimedArray = new T[index];

            Array.Copy(this.array, trimedArray, this.index);

            this.array = trimedArray;
        }
    }
}
