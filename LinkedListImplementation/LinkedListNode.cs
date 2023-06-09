using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LinkedListImplementation
{
    class LinkedListNode<T>
    {
        private Node<T> head;

        public class Node<T>
        {
            public T Data;
            public Node<T> Next;

            public Node(T data)
            {
                Data = data;

            }
        }
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public void AddAfter(T oldData, T data)
        {
            Node<T> newNode = new Node<T>(data);

            Node<T> temp = head;
            while (!temp.Data.Equals(oldData)) 
            {
                temp = temp.Next;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void DeleteFirst()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }

        public void DeleteLast()
        {
            if (head == null || head.Next == null)
            {
                head = null;
                return;
            }

            Node<T> temp = head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = null;
        }

        public void DeleteParticular(T data)
        {
            if (head == null)
                return;

            if (head.Data.Equals(data))
            {
                head = head.Next;
                return;
            }
            Node<T> temp = head;
            while (temp.Next != null && !temp.Next.Data.Equals(data))
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Data not found in the linkedlist");
                return;
            }

            temp.Next = temp.Next.Next;
        }
        public void Display()
        {
            Node<T> temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Console.Write("Linked list: ");
                while (temp != null)
                {
                    Console.Write(temp.Data + "->");
                    temp = temp.Next;
                }
                Console.WriteLine("END");
            }
        }

        // Stack Operations
        public void Push(T data)
        {
            AddFirst(data);
        }

        public void Pop()
        {
            DeleteFirst();
        }

        public T Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            return head.Data;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}


