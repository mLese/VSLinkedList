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
            throw new NotImplementedException();
        }

        public void addLast(T val)
        {
            throw new NotImplementedException();
        }

        public void clear()
        {
            throw new NotImplementedException();
        }

        public T getFirst()
        {
            throw new NotImplementedException();
        }

        public T getLast()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
