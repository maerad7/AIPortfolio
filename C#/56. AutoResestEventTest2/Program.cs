using System;
using System.Threading;
using System.Collections.Generic;

namespace AutoResestEventTest2
{
    class Program
    {
        static void Main(string[] args)
        {
             Traffic traffic = new Traffic();

            // 2개의 쓰레드 구동
            Thread v = new Thread(traffic.ProcessVertical);
            Thread h = new Thread(traffic.ProcessHorizontal);
            v.Start();
            h.Start();

            // 메인쓰레드에서 데이타 전송
            for (int i = 0; i < 30; i+=3)
            {
                traffic.AddVertical(new int[] { i, i + 1, i + 2 });
                traffic.AddHorizontal(new int[] { i, i + 1, i + 2 });
                Thread.Sleep(10);
            }

            Thread.Sleep(1000);
            traffic.Running = false;    
        }
    }
}
