<<<<<<< HEAD
﻿using System;


namespace delegate_basic
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
=======
﻿using System;


namespace delegate_basic
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
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
