<<<<<<< HEAD
﻿using System;

namespace GenericT
{
    class MyStack<T>
    {
        T[] _elements;
        int pos = 0;

        public MyStack()
        {
            _elements = new T[100];
        }

        public void Push(T element)
        {
            _elements[++pos] = element;
        }

        public T pop()
        {
            return _elements[pos--];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> numberStack = new MyStack<int>();
            MyStack<string> nameStack = new MyStack<string>();
        }
    }
}
=======
﻿using System;

namespace GenericT
{
    class MyStack<T>
    {
        T[] _elements;
        int pos = 0;

        public MyStack()
        {
            _elements = new T[100];
        }

        public void Push(T element)
        {
            _elements[++pos] = element;
        }

        public T pop()
        {
            return _elements[pos--];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> numberStack = new MyStack<int>();
            MyStack<string> nameStack = new MyStack<string>();
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
