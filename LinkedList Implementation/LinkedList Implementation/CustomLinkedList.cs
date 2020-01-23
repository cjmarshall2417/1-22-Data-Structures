using System;
using System.Collections.Generic;
using System.Text;

//A singly linked, non looping linkedlist implementation
namespace LinkedList_Implementation
{
    class CustomLinkedList
    {
        CustomLinkedListNode head;
        CustomLinkedListNode tail;
        int count = 0;


        public void AddNodeToTail(object value)
        {
            CustomLinkedListNode node = new CustomLinkedListNode(value);
            if (count == 0)
            {
                tail = node;
                head = node;
                count++;
            }
            else
            {
                tail.next = node;
                tail = node;
                count++;
            }
        }

        public void AddNodeToHead(object value)
        { 
            CustomLinkedListNode node = new CustomLinkedListNode(value);
            
            if(count == 0)
            {
                tail = node;
                head = node;
                count++;
            }
            else
            {
                node.next = head;
                head = node;
                count++;
            }
        }

        public void Traverse()
        {
            

            if(head == null)
            {
                throw new Exception("No nodes to traverse.");
            }
            else
            {
                CustomLinkedListNode node = head;
                
                for(int i = 0; i < count; i++) {
                    Console.WriteLine(node.value.ToString());
                    node = node.next;
                }
                
            }
        }

        public int Count()
        {
            return count;
        }

        public object[] ToArray()
        {
            if (head == null)
            {
                throw new Exception("No nodes to delete.");
            }
            object[] array = new object[count];
            CustomLinkedListNode node = head;
            for(int i = 0; i < count; i++)
            {
                array[i] = node.value;
                node = node.next;
            }

            return array;
        }

        public void DeleteByValue(object value)
        {
            if (head == null)
            {
                throw new Exception("No nodes to delete.");
            }
            if (head.value == value)
            {
                head = head.next;
                count--;
                return;
            }
            else if(tail.value == value)
            {
                CustomLinkedListNode tempNode = head;
                while(tempNode.next.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = null;
                tail = tempNode;
                count--;
                return;
            }
            
            CustomLinkedListNode node = head;
            while(node.next.value != value && node.next != tail)
            {
                node = node.next;
                
            }
            if(node.next == tail)
            {
                throw new Exception("Value was not found in linked list.");
            }

            node.next = node.next.next;
            count--;
            

        }

        public void DeleteFromHead()
        {
            if(head == null)
            {
                throw new Exception("No node to delete.");
            }
            head = head.next;
            count--;

        }

        public void DeleteFromTail()
        {
            if(head == null)
            {
                throw new Exception("No node to delete.");
            }
            CustomLinkedListNode node = head;
            
            if(node.next == null)
            {
                head = null;
                tail = null;
                count = 0;
                return;
            }

            while(node.next.next != null)
            {
                node = node.next;
            }

            node.next = null;
            tail = node;
            count--;



        }

        internal class CustomLinkedListNode
        {
            public object value { get; set; }
            public CustomLinkedListNode next { get; set; }

            public CustomLinkedListNode(object data)
            {
                value = data;
            }

        }

    }

    
}
