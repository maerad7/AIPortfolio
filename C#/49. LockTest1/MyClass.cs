using System;
using System.Threading;

namespace LockTest1
{
    public class MyClass
    {
        private int counter = 1000;

        // lock
        private object lockObject = new object();

        public void Run()
        {
            // 10개의 쓰레드가 동일 메서드 실행
            for (int i  = 0; i<10; i++)
            {
                new Thread(SafeCalc).Start();
            }
        }
        
        // Thread-Safe 메서드
        private void SafeCalc()
        {
            // 한번에 한 쓰레드만 lock블럭 실행
            lock (lockObject)
            {
                counter++;
                // 가정 : 다른 복잡한 일을 한다.

                for (int i = 0; i< counter; i++)
                    for (int j = 0; j <counter ; j++);

                // 필드 value 읽기
                Console.WriteLine(counter);
            }
        }
    }
}