using System;

namespace delegate1
{
    class MyClass
    {
        // 1. delegate 생성
        private delegate void RunDelegate(int i);

        // output : 1024
        private void RunThis(int val)
        {
            Console.WriteLine("{0}", val);
        }

        private void RunThat(int value)
        {
            Console.WriteLine("0x{0:x}", value);
        }

        public void Perform()
        {
            // 2. delegate 인스턴스 생성
            RunDelegate run = new RunDelegate(RunThis);
            // 3. delegate 실행
            run(1024);

            //run = new RunDelegate(RunThat); => run = RunThat;

            run = RunThat;

            run(1024);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Perform();
        }
    }
}
