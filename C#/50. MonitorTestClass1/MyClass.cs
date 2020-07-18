using System;
using System.Threading;

namespace MonitorTestClass1
{
    public class MyClass
    {
        private int counter = 1000;

        private object lockObject = new object();

        public void Run()
        {
            // 10 개의 쓰레드가 동일 메서드 실행
            for (int i = 0; i < 10; i++)
            {
                new Thread(SafeCalc).Start();
            }
        }

        // Thread-Safe하지 않은 메서드
        private void SafeCalc()
        {
            // 한번에 한 쓰레드만 lock 블럭 실행
            Monitor.Enter(lockObject);
            try
            {
                // 필드 value 변경
                counter ++;

                // 가정: 다른 복잡한 일을 한다.
                for ( int i = 0; i < counter ; i++)
                    for ( int j=0 ; j< counter; j++);

                // 읽기
                Console.WriteLine(counter);
            }
            finally
            {
                Monitor.Exit(lockObject);
            }
        }
    }
}