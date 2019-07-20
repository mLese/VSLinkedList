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
        void removeFirst();
        void removeLast();
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
            }
            else
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
            }
            else
            {
                MyNode<T> last = getLastNode();
                last.next = new MyNode<T>(val);
            }
        }

        public void clear()
        {
            head = null;
        }

        public T getFirst()
        {
            return head.value;
        }

        public T getLast()
        {
            if (size() == 0)
            {
                throw new Exception("list is empty");
            }
            else
            {
                MyNode<T> lastNode = getLastNode();
                return lastNode.value;
            }
        }

        public void remove(T val)
        {
            MyNode<T> currentNode = head;
            MyNode<T> prevNode = currentNode;

            if (size() == 0)
            {
                throw new Exception("list is empty");
            }
            else
            {
                while (!currentNode.value.Equals(val) && currentNode.next != null)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.next;
                }

                if (currentNode.value.Equals(val))
                {
                    if (currentNode.next == null) // end of list
                    {
                        prevNode.next = null;
                    }
                    else
                    {
                        prevNode.next = currentNode.next; // skip over found node
                    }
                }
            }
        }

        public void removeFirst()
        {
            head = head.next;
        }

        public void removeLast()
        {
            MyNode<T> currentNode = head;
            MyNode<T> prevNode = currentNode;

            if (size() == 0)
            {
                throw new Exception("list is empty");
            }
            else
            {
                while (currentNode.next != null)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.next;
                }
            }
            prevNode.next = null;
        }

        public int size()
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                int i = 1;
                MyNode<T> currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                    i++;
                }
                return i;
            }
        }
        private MyNode<T> getLastNode()
        {
            MyNode<T> currentNode = head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            return currentNode;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
