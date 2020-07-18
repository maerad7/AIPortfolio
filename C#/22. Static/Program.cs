using System;

namespace Static
{
    public class Myclass
    {
        private int val = 1;

        //인스턴스 메서드
        public int InstRun()
        {
            return val;
        }    

        // 정적(static) 메서드
        public static int Run()
        {
            return 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            int i = myclass.InstRun();

            int j = Myclass.Run();

            Console.WriteLine("i:{0} , j:{1}", i, j);
        }
    }
}
