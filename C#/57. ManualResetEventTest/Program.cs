using System;
using System.Threading;

namespace _57._ManualResetEventTest
{
    class Program
    {
        // ManualResetEvent 객체 필드
        static ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            // 10개 쓰레드 생성 후 쓰레드 모두 WaitOne() -> 실행 중지 후 대기 중
            for (int  i = 0; i < 10; i++)
            {
                new Thread(Run).Start(i);
            }

            // 메인쓰레드
            Thread.Sleep(3000);

            // ManualResetEvent 객체 Set() 호출
            // 10개 쓰레드 모두 실행 계속함
            manualResetEvent.Set();
        }

        static void Run(object id)
        {
             Console.WriteLine("{0} in Wait", id);

            // ManualResetEvent 신호 대기
            manualResetEvent.WaitOne();                        

            Console.WriteLine("{0}: Done", id);
        }
    }
}
