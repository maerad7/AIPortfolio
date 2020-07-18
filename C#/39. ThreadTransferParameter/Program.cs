using System;
using System.Threading;

namespace ThreadTransferParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 파라미터 없는 ThreadStart 사용
            Thread t1 = new Thread(new ThreadStart(Run));
            t1.Start();

            // ParamterizedThreadStart 파리미터 전달
            // Start()의 파라미터로 radius 전달
            Thread t2 = new Thread(new ParameterizedThreadStart(Calc));
            t2.Start(10.00);

            //ThreadStart 에서 파라미터 전달
            Thread t3 = new Thread(()=> Sum(10,20,30));
            t3.Start();
       }
       static void Run()
       {
           Console.WriteLine("Run");

       }
       static void Calc(object raidus)
       {
           double r = (double)raidus;
           double area = r*r*3.14;
           Console.WriteLine("r={0}, aera={1}", r, area);
       }
       static void Sum(int d1, int d2, int d3)
       {
           int sum = d1 + d2 + d3;
           Console.WriteLine(sum);
       }
    }
}
