<<<<<<< HEAD
﻿using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;

namespace _51._MonitorClassTest2
{
    class Program
    {
        static Queue Q = new Queue();
        static object lockObj = new object();
        static bool running = true;

        static void Main(string[] args)
        {
            // Reader 쓰레드 시작
            Thread reader = new Thread(ReadQueue);
            reader.Start();

            // writer 쓰레드를 시작
            List<Thread> thrds = new List<Thread>();
            for (int i = 0; i<10 ; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(WriteQueue));
                t.Start(i);
                thrds.Add(t);
            }

            // 모든 writer가 종료 될 때 까지 대기
            thrds.ForEach(p => p.Join());

            // reader 종료
            running = false;                
        

        }
        
        static void WriteQueue(object val)
        {
            lock (lockObj)
            {
                Q.Enqueue(val);
                Console.WriteLine("W:{0}",val);
                Monitor.Pulse(lockObj);
            }
        }
        
        static void ReadQueue()
        {
            while(running)
            {
                lock (lockObj)
                {
                    while(Q.Count == 0)
                    {
                        Monitor.Wait(lockObj);
                    }

                    int qCount = Q.Count;
                    for (int i = 0 ; i < qCount ; i++)
                    {
                        int val = (int)Q.Dequeue();
                        Console.WriteLine("R:{0}",val);
                    }
                }
            }
        }
    }

}
=======
﻿using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;

namespace _51._MonitorClassTest2
{
    class Program
    {
        static Queue Q = new Queue();
        static object lockObj = new object();
        static bool running = true;

        static void Main(string[] args)
        {
            // Reader 쓰레드 시작
            Thread reader = new Thread(ReadQueue);
            reader.Start();

            // writer 쓰레드를 시작
            List<Thread> thrds = new List<Thread>();
            for (int i = 0; i<10 ; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(WriteQueue));
                t.Start(i);
                thrds.Add(t);
            }

            // 모든 writer가 종료 될 때 까지 대기
            thrds.ForEach(p => p.Join());

            // reader 종료
            running = false;                
        

        }
        
        static void WriteQueue(object val)
        {
            lock (lockObj)
            {
                Q.Enqueue(val);
                Console.WriteLine("W:{0}",val);
                Monitor.Pulse(lockObj);
            }
        }
        
        static void ReadQueue()
        {
            while(running)
            {
                lock (lockObj)
                {
                    while(Q.Count == 0)
                    {
                        Monitor.Wait(lockObj);
                    }

                    int qCount = Q.Count;
                    for (int i = 0 ; i < qCount ; i++)
                    {
                        int val = (int)Q.Dequeue();
                        Console.WriteLine("R:{0}",val);
                    }
                }
            }
        }
    }

}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
