using System;
using System.Collections.Generic;
using System.Text;

namespace ListLinkedDoble
{
    public class LinkedList<T>
    {
        private Node<T> head, tail;
        public int Count { get; set; }
        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }

        public Node<T> Tail
        {
            get { return tail; }
            set { tail = value; }
        }
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }
        public bool IsEmpty()
        {
            return tail is null;
        }
        public int Insert(T value)
        {
            Node<T> createNode=new Node<T>(value);
            if (IsEmpty())
            {
                tail = createNode;
                head = createNode;
                Count++;
                return 1;
            }
            tail.Next = createNode;
            tail = createNode;
            ++Count;
            return 1;
        }
        public T Remove(T value)
        {
            if (!IsEmpty())
            {
                Node<T> oldNode = this.head;
                if (!(oldNode is null)&&oldNode.Equals(value)) {
                    tail = this.head.Next;
                }
                else
                {
                    tail = this.SearchNode(value);
                    oldNode.Next = oldNode != null? oldNode.Next?.Next:null;

                }
                return value;
            }
            return default;
        }
        public Node<T> SearchNode(T item)
        {
            Node<T> node = this.head;
            while (node != null)
            {
                if (node.Equals(item))
                {
                    return node;
                }
                node = node.Next;
            }
            return null;
        }

        public int Repetitive { get; set; }
        public void PrintConsole()
        {
            Node<T> print = head;
            Console.WriteLine("Listado de todos los elementos de la cola.");
            while (print!=null)
            {
                Console.WriteLine(print.Value);
                if (print.Value.Equals(print.Value))
                {
                    ++Repetitive;
                }
                print = print.Next;
            }
        }
        public Node<T> CountRepetitiveNumber( T value)
        {
            Node<T> node = this.head;
            while (node != null)
            {
                if (node.Value.Equals(value))
                {
                    ++Repetitive;
                }
                node = node.Next;
            }
            Console.WriteLine($"Numero: {value} cantidad de repeticion: {Repetitive}");
            return node;
        }
    }
}
