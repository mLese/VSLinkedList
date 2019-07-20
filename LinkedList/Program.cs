using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    interface ILinkedList<T>
    {
        T getFirst();
        T getLast();
        T removeFirst();
        T removeLast();
        void addFirst(T val);
        void addLast(T val);
        void remove(T val);
        int size();
        void clear();
    }

    public class MyNode<T>
    {
        public T value;
        public MyNode<T> next;

        public MyNode(T value) {
            this.value = value;
            next = null;
        }
    }

    public class MyLinkedList<T> : ILinkedList<T>
    {
        MyNode<T> head = null;

        public void addFirst(T val)
        {
            if (head == null)
            {
                head = new MyNode<T>(val);
            } else
            {
                MyNode<T> newHead = new MyNode<T>(val);
                newHead.next = head;
                head = newHead;
            }
        }

        public void addLast(T val)
        {
            if (head == null)
            {
                head = new MyNode<T>(val);
            } else
            {
                MyNode<T> currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = new MyNode<T>(val);
            }
        }

        public void clear()
        {
            head = null;
        }

        public T getFirst()
        {
            throw new NotImplementedException();
        }

        public T getLast()
        {
            if (size() == 0)
            {
                throw new Exception("list is empty");
            } else
            {
                MyNode<T> currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                return currentNode;
            }
        }

        public void remove(T val)
        {
            throw new NotImplementedException();
        }

        public T removeFirst()
        {
            throw new NotImplementedException();
        }

        public T removeLast()
        {
            throw new NotImplementedException();
        }

        public int size()
        {
            if (head == null)
            {
                return 0;
            } else
            {
                return 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
