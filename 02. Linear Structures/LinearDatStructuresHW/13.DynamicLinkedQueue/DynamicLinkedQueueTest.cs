namespace DynamicLinkedQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DynamicLinkedQueueTest
    {
         static void Main()
        {
             
            var linked = new DynamicLinkedQueue<int>();
            linked.Enqueue(5);
            linked.Enqueue(3);
            linked.Enqueue(1111111111);
            linked.Enqueue(2);

            linked.Dequeue();

            Console.WriteLine("LinkedList.Count = " + linked.Count);

            linked.PrintList();

            Console.WriteLine("After removing elements");
            linked.Dequeue();
            linked.Dequeue();
            linked.PrintList();
        }
    }
}
