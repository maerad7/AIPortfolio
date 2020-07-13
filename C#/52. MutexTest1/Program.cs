using System;
using System.Threading;
using System.Collections.Generic;

namespace MutexTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => MyClass.AddList(10));
            Thread t2 = new Thread(() => MyClass.AddList(20));
            t1.Start();
            t2.Start();

            // 2개의 쓰레드 실행완료까지 대기
            t1.Join();
            t2.Join();

            // 메인쓰레드에서 뮤텍스 사용
            using( Mutex m = new Mutex(false, "MutexName1"))
            {
                // 뮤텍스를 취득하기 위해 10ms 대기
                if (m.WaitOne(10))
                {
                    // 뮤텍스 취득후 MyList 사용
                    MyClass.MyList.Add(30);
                }
                else
                {
                    Console.WriteLine("Cannot acquire mutex");
                }
            } 

            MyClass.ShowList();
        }
     
    }
}
