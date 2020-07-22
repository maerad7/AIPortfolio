<<<<<<< HEAD
﻿using System;

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
=======
﻿using System;

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
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
