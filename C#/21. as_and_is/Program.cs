using System;

namespace as_and_is
{
    class MyBase {}
    class MyClass : MyBase {}

    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            bool ok = new Program().Test(c);
            Console.WriteLine(ok);
        }

        public bool Test(object obj)
        {
            //as
            MyBase a = obj as MyBase;

            //is
            bool ok = obj is MyBase;

            //Expict Casting

            MyBase b = (MyBase) obj;

            return ok;
        }
    }
}
