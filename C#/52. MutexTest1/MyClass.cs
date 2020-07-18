using System;
using System.Threading;
using System.Collections.Generic;   

namespace MutexTest1
{
    public class MyClass
    {
        // MutexName1 이라는 뮤텍스 생성
        private static Mutex mtx = new Mutex(false , "MutexName1");

        // 데이터 멤버
        public static List<int> MyList = new List<int>();

        // 데이터를 리스트에 추가
        public static void AddList(int val)
        {
            // 뮤텍스를 취득할 때까지 대기
            mtx.WaitOne();

            // 뮤텍스 취득 후 실행 블럭
            MyList.Add(val);

            // 뮤텍스 해제
            mtx.ReleaseMutex();
        }

        // 리스트 출력
        public static void ShowList()
        {
            MyList.ForEach(p=> Console.WriteLine(p));
        }
    }
}