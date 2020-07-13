using System;
using System.Threading;

namespace SemaphoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
             MyClass c = new MyClass();

            // 10개 쓰레드들 실행
            // 처음 5개만 먼저 실행되고 하나씩 해제와 함께
            // 실행될 것임.
            for (int i = 1; i <= 10; i++)
            {
                new Thread(c.Run).Start(i);
            }
        }
    }
}
