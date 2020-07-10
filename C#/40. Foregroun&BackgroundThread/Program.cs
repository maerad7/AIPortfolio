using System;
using System.Threading;

namespace Foregroun_BackgroundThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Run));            
            t1.Start();
                        
            // 백그라운드 쓰레드
            Thread t2 = new Thread(new ThreadStart(Run));
            t2.IsBackground = true;
            t2.Start();       
        }
        static void Run()
        {
            Console.WriteLine("Thread start");
        }
    }
}
