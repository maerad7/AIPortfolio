using System;
using System.Threading;

namespace ThreadDifferntClass
{
    class Helper
    {
        public void Run()
        {
            Console.WriteLine("Helper Run");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Helper 클래스의 Run메서드 호출
            Helper obj = new Helper();
            Thread t = new Thread(obj.Run);
            t.Start();
        }
    }
}
