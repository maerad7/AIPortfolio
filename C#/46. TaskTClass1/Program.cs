<<<<<<< HEAD
﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task<T>를 이용하여 쓰레드 생성과 시작
            Task<int> task = Task.Factory.StartNew<int>(() => CalcSize("Hello world"));

            // 메인쓰레드에서 다른 작업 실행
            Thread.Sleep(1000);

            // 쓰레드 결과 리턴. 쓰레드가 꼐속 실행중이면 이곳에서 끝날EoRkwl eorlgka
            int result = task.Result;

            Console.WriteLine("Result={0}", result);
        }

        static int CalcSize(string data)
        {
            string s = data == null ? "" :  data.ToString();
            // 복잡한 계산 가정

            return s.Length;
        }
    }
}
=======
﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task<T>를 이용하여 쓰레드 생성과 시작
            Task<int> task = Task.Factory.StartNew<int>(() => CalcSize("Hello world"));

            // 메인쓰레드에서 다른 작업 실행
            Thread.Sleep(1000);

            // 쓰레드 결과 리턴. 쓰레드가 꼐속 실행중이면 이곳에서 끝날EoRkwl eorlgka
            int result = task.Result;

            Console.WriteLine("Result={0}", result);
        }

        static int CalcSize(string data)
        {
            string s = data == null ? "" :  data.ToString();
            // 복잡한 계산 가정

            return s.Length;
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
