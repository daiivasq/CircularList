using System;
using System.Collections.Generic;

namespace ListLinkedDoble
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte input = 0;
            do
            {
                
                Console.WriteLine("1. Tarea 1.");
                Console.WriteLine("2. Tarea 2.");
                Console.WriteLine("3. Salir.");
                input = sbyte.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        LinkedList<int> a = new LinkedList<int>();
                        a.Insert(1);
                        a.Insert(2);
                        a.Insert(1);
                        a.Insert(2);
                        a.Insert(1);
                        a.Insert(3);
                        a.Insert(1);
                        Console.WriteLine(a.CountRepetitiveNumber(1));
                        break;
                    case 2:
                        CircularLinkedList<int> originalList = new CircularLinkedList<int>();
                        originalList.lastValue = null;

                        originalList.addValue(0);
                        
                        originalList.addValueAtTheBeginning(9);
                        originalList.addValueAtTheBeginning(8);
                        originalList.addValueAtTheBeginning(7);
                        originalList.addValueAtTheBeginning(3);
                        originalList.addValueAtTheBeginning(1);
                        originalList.addValueAtTheBeginning(2);
                        originalList.addValueAtTheBeginning(5);
                        originalList.PrintList();

                        int addedValue =  originalList.listLenght()%2==0? originalList.listLenght()/2 : (originalList.listLenght()/2)+1;

                        CircularLinkedList<int> splittedList = new CircularLinkedList<int>();

                        splittedList.lastValue = originalList.splitList(addedValue);

                        splittedList.PrintList();
                        originalList.PrintList();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            } while (input!=3);
            

        }
    }
}
