using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class MainQueue<T> : IEnumerable<Node<T>>
    {
        public CustomQueue<T>[] Queues { get; set; }

        public Node<T> HeadNode { get; set; }
        public Node<T> TailNode { get; set; }
        public int Length { get; private set; }

        public MainQueue(params CustomQueue<T>[] queues)
        {
            Queues = queues;
            SortQueues();
        }

        private void SortQueues()
        {
            Array.Sort(Queues, (queue, customQueue) =>
            {
                if (queue.CompareTo(customQueue) > 0)
                {
                    return 1;
                }
                if (queue.CompareTo(customQueue) < 0)
                {
                    return -1;
                }
                return 0;
            });
        }

        public void CreateQueue()
        {
            for (int i = 0; i < Queues.Length - 1; i++)
            {
                Queues[i].TailNode.Next = Queues[i + 1].HeadNode;
            }
            HeadNode = Queues[0].HeadNode;
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            var current = HeadNode;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var node in this)
            {
                builder.Append(node.Value + " -> ");
            }
            return builder.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
