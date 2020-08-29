using System;
using System.Collections.Generic;
using System.Text;

namespace ListLinkedDoble
{
    public class Node<T>
    {
        private T value;

        public T Value
        {
            get => this.value;
        }
        public Node<T> Next { get; set; }
        public Node(T value,Node<T> next=null)
        {
            this.value = value;
            this.Next = next;
        }

    }
}
