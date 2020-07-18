using System;

namespace ReadonlyConstant
{
    class ReadonlyConstant
    {
        const int MAX_VALUE = 1024;

        readonly int Max;
        public ReadonlyConstant()
        {
            Max = 1;
        }

        public void Method1()
        {
            Console.WriteLine(MAX_VALUE);
            Console.WriteLine(Max);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           ReadonlyConstant rc = new ReadonlyConstant();
           rc.Method1();
        }
    }
}
