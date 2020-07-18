<<<<<<< HEAD
﻿using System;
using System.Threading;

namespace AsyncDelgateT
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetArea() 메서드를 이용하여 닷넷의 Func 델리게이트 인스턴스를 생성 한다.
            // Func의 처음 2개 int는 입력, 마지막 int는 출력 타입
            Func<int,int,int> work = GetArea;

            // 델리게이트 객체로부터 BeginInvoke() 실행
            // 두 개의 입력 파라미터 10, 20 지정
            IAsyncResult asyncRes = work.BeginInvoke(10, 20, null, null);

            Console.WriteLine("Do something in Main thread");

            // 델리게이트 객체로부터 EndInvoke(IAsyncResult) 실행
            // EndInvoke는 쓰레드가 완료되길 기다린다.
            // 완료후 리턴 value를 돌려받는다.
            int result = work.EndInvoke(asyncRes);
        }
        static int GetArea(int height, int width)
        {
            int area = height * width;
            return area;
        }
    }
}
=======
﻿using System;
using System.Threading;

namespace AsyncDelgateT
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetArea() 메서드를 이용하여 닷넷의 Func 델리게이트 인스턴스를 생성 한다.
            // Func의 처음 2개 int는 입력, 마지막 int는 출력 타입
            Func<int,int,int> work = GetArea;

            // 델리게이트 객체로부터 BeginInvoke() 실행
            // 두 개의 입력 파라미터 10, 20 지정
            IAsyncResult asyncRes = work.BeginInvoke(10, 20, null, null);

            Console.WriteLine("Do something in Main thread");

            // 델리게이트 객체로부터 EndInvoke(IAsyncResult) 실행
            // EndInvoke는 쓰레드가 완료되길 기다린다.
            // 완료후 리턴 value를 돌려받는다.
            int result = work.EndInvoke(asyncRes);
        }
        static int GetArea(int height, int width)
        {
            int area = height * width;
            return area;
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
