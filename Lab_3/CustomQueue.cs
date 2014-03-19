using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class CustomQueue<T> : IComparable<CustomQueue<T>>, IEnumerable<Node<T>>
    {
        public Node<T> HeadNode { get; set; }
        public Node<T> TailNode { get; set; }
        public int Length { get; private set; }
        public int Priority { get; set; }

        public CustomQueue(int priority)
        {
            Length = 0;
            HeadNode = null;
            TailNode = HeadNode;
            Priority = priority;
        }

        public void Enqueue(T element)
        {
            var newNode = new Node<T>(element);

            if (HeadNode == null)
            {
                HeadNode = newNode;
                TailNode = HeadNode;
            }
            else
            {
                TailNode.Next = newNode;
                TailNode = TailNode.Next;
                TailNode.Next = null;
            }
            Length++;
        }

        public int CompareTo(CustomQueue<T> other)
        {
            if (Priority > other.Priority)
            {
                return 1;
            }
            if (Priority < other.Priority)
            {
                return -1;
            }
            return 0;
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
    }
}
