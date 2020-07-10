﻿using System;
using System.Threading;

namespace ThreadPool1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 쓰레드 풀에 있는 쓰레드를 이용하여 Calc() 메서드 실행 -> 리턴 vlaue가 없을 경우 사용
            ThreadPool.QueueUserWorkItem(Calc); // radius =null
            ThreadPool.QueueUserWorkItem(Calc,10.0);
            ThreadPool.QueueUserWorkItem(Calc,20.0);

            Console.ReadLine();

        }
        static void Calc(object radius)
        {
            if (radius == null) return;

            double r = (double)radius;
            double area = r * r * 3.14;
            Console.WriteLine("r={0}, area={1}", r, area);  
        }
    }
}
