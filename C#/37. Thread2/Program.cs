using System;
using System.Threading;

namespace Thread2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run 메소드를 입력받아 THreadStart 델리게이트 타입 객체를 생성한 후 Thread 클래스 생성자에 전달
            Thread t1 = new Thread(new ThreadStart(Run));
            t1.Start();

            // 컴파일러가 RUn() 메소드의 함수 프로토타입으로 부터 ThreadStart Delegate 객체를 추론하여 생성함
            Thread t2 = new Thread(Run);

            // 익명 메서드를 사용하여 쓰레드 생성
            Thread t3 = new Thread(delegate()
            {
                Run();
            }
            );
            t3.Start();

            // 람다식을 사용하여 쓰레드 생성
            Thread t4 = new Thread(() => Run());
            t4.Start();

            // easy
            new Thread(() => Run()).Start();
        }

        static void Run()
        {
            Console.WriteLine("Run");
        }
    }
}
