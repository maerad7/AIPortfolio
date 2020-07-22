<<<<<<< HEAD
﻿using System;
using System.Threading;

namespace AutoResetEventTest1
{
    class Program
    {
        // AutoResetEvent 객체 필드
        static AutoResetEvent autoEvent = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            // 쓰레드 A 생성
            Thread A = new Thread(Run);
            A.Name = "Thread A";
            A.Start();

            // 메인Tmfpem
            Thread.Sleep(3000);
            autoEvent.Set();// 쓰레드 A 에 신호

        }

        static void Run()
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine("{0}: Run Start", name);

            // AutoResetEvent 신호 대기
            autoEvent.WaitOne();
            Console.WriteLine("{0} : DoWork", name);

            Console.WriteLine("{0}: Run End", name);
        }
    }
}
=======
﻿using System;
using System.Threading;

namespace AutoResetEventTest1
{
    class Program
    {
        // AutoResetEvent 객체 필드
        static AutoResetEvent autoEvent = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            // 쓰레드 A 생성
            Thread A = new Thread(Run);
            A.Name = "Thread A";
            A.Start();

            // 메인Tmfpem
            Thread.Sleep(3000);
            autoEvent.Set();// 쓰레드 A 에 신호

        }

        static void Run()
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine("{0}: Run Start", name);

            // AutoResetEvent 신호 대기
            autoEvent.WaitOne();
            Console.WriteLine("{0} : DoWork", name);

            Console.WriteLine("{0}: Run End", name);
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
