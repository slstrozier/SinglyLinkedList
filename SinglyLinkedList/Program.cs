using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Node
    {
        public Node Next { get; set; }
        public object Value { get; set; }
    }

    class SinglyLinkedList
    {
        private Node head;
        private Node current;
        public int Count;

        public SinglyLinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node() { Value = data};
            current.Next = newNode;
            current = newNode;
            Count++;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;
            head.Next = newNode;
            Count++;
        }

        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
            }
            else
            {
                Console.WriteLine("No Elements exist in this Linked List.");
            }
        }

        public List<Node> Reverse()
        {
            Stack<Node> nodeStack = new Stack<Node>();
            while (head != null)
            {
                nodeStack.Push(head);
                head = head.Next;
            }

            return nodeStack.ToList<Node>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList lnkdList = new SinglyLinkedList();
            lnkdList.AddAtLast(12);
            lnkdList.AddAtLast(5);
            lnkdList.AddAtLast(2);
            lnkdList.AddAtLast(11); //Looking for 11
            lnkdList.AddAtLast(67);
            lnkdList.AddAtLast(7);
            lnkdList.AddAtLast(15);
            lnkdList.AddAtLast(65);


            Console.WriteLine(lnkdList.Reverse()[5].Value);
           
            Console.ReadKey();

        }
    }
}
