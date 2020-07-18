<<<<<<< HEAD
﻿using System;
using System.Threading.Tasks;

namespace TaskClassTest
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Task.Factory를 이용하여 쓰레드 생성과 시작
            Task.Factory.StartNew(new Action<object>(Run), null);
            Task.Factory.StartNew(new Action<object>(Run),"1st");
            Task.Factory.StartNew(Run,"2nd");

            Console.Read();
        }

        static void Run(object data)
        {
            Console.WriteLine(data == null ? "NULL" : data);
        }
    }
}
=======
﻿using System;
using System.Threading.Tasks;

namespace TaskClassTest
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Task.Factory를 이용하여 쓰레드 생성과 시작
            Task.Factory.StartNew(new Action<object>(Run), null);
            Task.Factory.StartNew(new Action<object>(Run),"1st");
            Task.Factory.StartNew(Run,"2nd");

            Console.Read();
        }

        static void Run(object data)
        {
            Console.WriteLine(data == null ? "NULL" : data);
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
