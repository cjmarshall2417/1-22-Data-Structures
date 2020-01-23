using System;

namespace LinkedList_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();
            list.AddNodeToTail("B");
            list.AddNodeToTail("C");
            list.AddNodeToHead("A");

            list.Traverse();

            Console.WriteLine(list.Count());

            foreach(object value in list.ToArray())
            {
                Console.WriteLine(value.ToString());
            }

            list.DeleteFromTail();

            list.Traverse();

            list.AddNodeToTail("C");
            list.AddNodeToTail("D");
            list.DeleteByValue("C");

            list.Traverse();

                
        }
    }
}
