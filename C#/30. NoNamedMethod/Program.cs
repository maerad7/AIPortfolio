<<<<<<< HEAD
﻿using System;

namespace NoNamedMethod
{
    
    class Program
    {

        delegate void MyDelegate(int a);
        static void Main(string[] args)
        {
          
            

            MyDelegate d = delegate(int p)
            {
                Console.Write(p);
            };
            d(100);
        }
    }
}
=======
﻿using System;

namespace NoNamedMethod
{
    
    class Program
    {

        delegate void MyDelegate(int a);
        static void Main(string[] args)
        {
          
            

            MyDelegate d = delegate(int p)
            {
                Console.Write(p);
            };
            d(100);
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
