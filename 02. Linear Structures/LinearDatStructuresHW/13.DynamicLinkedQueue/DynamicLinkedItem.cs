namespace DynamicLinkedQueue
{
    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> NextItem { get; set; }

        public QueueItem(T data)
        {
            this.Value = data;
        }
    }
}
