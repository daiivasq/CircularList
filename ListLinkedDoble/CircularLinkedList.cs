using System;
using System.Collections.Generic;
using System.Text;

namespace ListLinkedDoble
{
    public class CircularLinkedList<T>
    {
        public Node<T> lastValue;
        public Node<T> addValueAtTheBeginning(T value)
        {

            if (lastValue == null)
                return addValue(value);
            Node<T> baseNode = new Node<T>(value);

            baseNode.Next = this.lastValue.Next;
            this.lastValue.Next = baseNode;

            return this.lastValue;
        }

        public Node<T> addValue(T value)
        {

            Node<T> baseNode = new Node<T>(value);
            this.lastValue = baseNode;
            this.lastValue.Next = this.lastValue;

            return lastValue;
        }

        public int listLenght()
        {
            int i = 0;

            Node<T> runList = this.lastValue.Next;
            while (runList.Next != this.lastValue.Next)
            {
                i++;
                runList = runList.Next;
            }

            return (i + 1);
        }

        public Node<T> splitList(T splitValues)
        {
            Node<T> baseNode = new Node<T>(splitValues);

            Node<T> newValue, runList = this.lastValue;
            for (int i = 0; i < int.Parse($"{splitValues}")  ; i++)
            {
                runList = runList.Next;
            }

            newValue = runList;
            baseNode.Next = runList.Next;
            newValue.Next = this.lastValue.Next;
            this.lastValue.Next = baseNode.Next;

            return newValue;
        }

        public void PrintList()
        {
            Node<T> printedValue;

            printedValue = this.lastValue.Next;

            do
            {
                Console.Write($"{printedValue.Value}{" "}");
                printedValue = printedValue.Next;
            } while (printedValue != this.lastValue.Next);

            Console.WriteLine("");
        }
    }
}
