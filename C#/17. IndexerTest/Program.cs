<<<<<<< HEAD
﻿using System;

namespace IndexerTest
{
    class MyClass
    {
        private const int MAX = 10;
        private string name;

        private int[] data = new int[MAX];

        public int this[int index]
        {
            get
            {
                if ( index < 0 || index >= MAX)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return data[index];
                }
            }
            set
            {
                if (!(index < 0 || index >= MAX))
                {
                    data[index] = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass cls = new MyClass();

            cls[1] = 1204;

            int i= cls[1];

            Console.WriteLine(i);
        }
    }
}
=======
﻿using System;

namespace IndexerTest
{
    class MyClass
    {
        private const int MAX = 10;
        private string name;

        private int[] data = new int[MAX];

        public int this[int index]
        {
            get
            {
                if ( index < 0 || index >= MAX)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return data[index];
                }
            }
            set
            {
                if (!(index < 0 || index >= MAX))
                {
                    data[index] = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass cls = new MyClass();

            cls[1] = 1204;

            int i= cls[1];

            Console.WriteLine(i);
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
