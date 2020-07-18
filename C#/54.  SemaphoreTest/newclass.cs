using System;
using System.Threading;


namespace SemaphoreTest
{
    public class MyClass
    {
        private Semaphore sema;

        public MyClass()
        {
            // 5개의 쓰레드만 허용
            sema = new Semaphore(5, 5);
        }

        public void Run(object seq)
        {
            // 쓰레드가 가진 데이타(일련번호)
            Console.WriteLine(seq);

            // 최대 5개 쓰레드만 아래 문장 실행
            sema.WaitOne();
            
            Console.WriteLine("Running#" + seq);
            Thread.Sleep(500);
            
            // Semaphore 1개 해체. 
            // 이후 다음 쓰레드 WaitOne()에서 진입 가능
            sema.Release();
            
        }
    }
}