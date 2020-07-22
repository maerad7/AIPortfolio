<<<<<<< HEAD
﻿using System;
using System.Threading;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().DoTest();
        }

        void DoTest()
        {
            // 새로운 쓰레드에서 Run() 실행
            Thread t1 = new Thread(new ThreadStart(Run));
            t1.Start();

            // 메인 쓰레드에서 Run() 실행
            Run();
        }

        void Run()
        {
            Console.WriteLine("Thread#{0}: Begin", Thread.CurrentThread.ManagedThreadId);
            // Do Something
            Thread.Sleep(3000);
            Console.WriteLine("Thread#{0}: End", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
=======
﻿using System;
using System.Threading;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().DoTest();
        }

        void DoTest()
        {
            // 새로운 쓰레드에서 Run() 실행
            Thread t1 = new Thread(new ThreadStart(Run));
            t1.Start();

            // 메인 쓰레드에서 Run() 실행
            Run();
        }

        void Run()
        {
            Console.WriteLine("Thread#{0}: Begin", Thread.CurrentThread.ManagedThreadId);
            // Do Something
            Thread.Sleep(3000);
            Console.WriteLine("Thread#{0}: End", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
