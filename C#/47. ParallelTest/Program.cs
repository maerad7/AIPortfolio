﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 순차적 실행
            // 동일쓰레드가 0~999 출력
            //
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("{0}: {1}",Thread.CurrentThread.ManagedThreadId, i);
            }
            Console.Read();

            // 2. 병렬처리
            // 다중쓰레드가 병렬로 출력
            //
            Parallel.For(0, 1000, (i) =>{
                Console.WriteLine("{0}: {1}",Thread.CurrentThread.ManagedThreadId, i);
            });
        }
    }
}
