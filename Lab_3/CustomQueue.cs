using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class CustomQueue<T>
    {
        private Node<T> HeadNode { get; set; }
        private Node<T> TailNode { get; set; }
        public int Length { get; private set; }

        public CustomQueue()
        {
            Length = 0;
            HeadNode = null;
            TailNode = HeadNode;
        }

        public void Enqueue(T element)
        {
            var newNode = new Node<T>(element);

            if (HeadNode == null)
            {
                HeadNode = newNode;
                TailNode = HeadNode;
                Length++;
            }
            else
            {
                newNode.Next = HeadNode;
                HeadNode = newNode;
            }
        }
    }
}
