<<<<<<< HEAD
﻿using System;

namespace Partial
{
    // 1. Partial Class - 3개로 분리한 경우
    partial class Class1
    {
        public void Run() { }
    }

    partial class Class1
    {
        public void Get() { }
    }

    partial class Class1
    {
        public void Put() { }
    }

    // 2. Partial Struct
    partial struct Struct1
    {
        public int ID;
    }

    partial struct Struct1
    {
        public string Name;

        public Struct1(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }

    // 3. Partial Interface
    partial interface IDoable
    {
        string Name { get; set; }
    }

    partial interface IDoable
    {
        void Do();
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
=======
﻿using System;

namespace Partial
{
    // 1. Partial Class - 3개로 분리한 경우
    partial class Class1
    {
        public void Run() { }
    }

    partial class Class1
    {
        public void Get() { }
    }

    partial class Class1
    {
        public void Put() { }
    }

    // 2. Partial Struct
    partial struct Struct1
    {
        public int ID;
    }

    partial struct Struct1
    {
        public string Name;

        public Struct1(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }

    // 3. Partial Interface
    partial interface IDoable
    {
        string Name { get; set; }
    }

    partial interface IDoable
    {
        void Do();
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
