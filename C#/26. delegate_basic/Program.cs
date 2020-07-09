using System;


namespace delegate1
{
    class Program
    {
        delegate int MyDelegate(string s);
        static void Main(string[] args)
        {
            new Program().Test();
        }

        void Test()
        {
            MyDelegate m = new MyDelegate(StringToInt);

            Run(m);
        }

        int StringToInt(string s)
        {
            return int.Parse(s);
        }

        void Run(MyDelegate m)
        {
            int i = m("123");

            Console.WriteLine(i);
        }
    }
}
