<<<<<<< HEAD
﻿using System;

namespace PassbyReference
{
    class Program
    {   
        static double GetData(ref int a, ref double b)
        {
            return ++a * ++b ;
        }
        static bool GetData(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }
        static void Main(string[] args)
        {
            // ref 사용. 초기화 필요
            int x =1;
            double y = 1.0;
            double ret = GetData(ref x, ref y);
            Console.WriteLine("x :" + x + "y: " + y);
            //out 사용 초기화 불필요
            int c, d ;
            bool bret = GetData(10, 20, out c, out d);
            Console.WriteLine("c :" + c + "d: " + d);
        }
    }
}
=======
﻿using System;

namespace PassbyReference
{
    class Program
    {   
        static double GetData(ref int a, ref double b)
        {
            return ++a * ++b ;
        }
        static bool GetData(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }
        static void Main(string[] args)
        {
            // ref 사용. 초기화 필요
            int x =1;
            double y = 1.0;
            double ret = GetData(ref x, ref y);
            Console.WriteLine("x :" + x + "y: " + y);
            //out 사용 초기화 불필요
            int c, d ;
            bool bret = GetData(10, 20, out c, out d);
            Console.WriteLine("c :" + c + "d: " + d);
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
