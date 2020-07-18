using System;
using System.Threading.Tasks;

namespace TaskClassTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taske 생성자에 Run을 지정 Task 객체 생성
            Task t1 = new Task(new Action(Run));
            
            // 람다식을 이용한 Task 객체 생성
            Task t2 = new Task(()=>
            {
                Console.WriteLine("Long query");
            }
            );

            t1.Start();
            t2.Start();

            // Task가 끝날 때까지 대기
            t1.Wait();
            t2.Wait();

        }

        static void Run()
        {
            Console.WriteLine("Long running method");
        }
    }
}
