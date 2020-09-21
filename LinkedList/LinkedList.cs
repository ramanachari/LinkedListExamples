using System;

namespace LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node NextNode { get; set; }
        public Node(int data)
        {
            this.Data = data;
            NextNode = null;
        }
        
    }

    class LinkedList
    {
        Node list = null;

        public void InsertFront(int data)
        {
            Node newNode = new Node(data);
            if (list == null)
            {
                list = newNode;
                return;
            }

            newNode.NextNode = list;
            list = newNode;
        }

        public void InsertRare(int data)
        {
            Node newNode = new Node(data);
            if (list == null)
            {
                list = newNode;
                return;
            }
            Node temp = list;
            while (temp.NextNode != null)
            {
                temp = temp.NextNode;
            }
            temp.NextNode = newNode;
        }

        public void InsertAtPosition(int data,int position)
        {
            int currentPosition = 1;
            Node temp = list;

            while (currentPosition < position)
            {
                temp = temp.NextNode;
                currentPosition++;
            }
            Node newNode = new Node(data);
            newNode.NextNode = temp.NextNode;
            temp.NextNode = newNode;
        }

        public void ReverseList()
        {
            Node current = list,prev=null,next;
            list = null;
            while (current != null)
            {
                next = current.NextNode;
                current.NextNode = prev;
                prev = current;
                current = next;
            }
            list = prev;
        }

        public void PrintList()
        {
            Console.WriteLine();
            Node temp = list;
            while (temp != null)
            {
                Console.Write(temp.Data+" ");
                temp = temp.NextNode;
            }
            Console.WriteLine();
        }

    }
}
