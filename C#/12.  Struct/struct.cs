<<<<<<< HEAD
﻿using System;

namespace Struct
{
   
    class Program
    {
        struct MyPoint
        {
            public int X;
            public int Y;

            public MyPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0},{1})", X, Y);
            }
        }
        static void Main(string[] args)
        {
            MyPoint pt = new MyPoint(10, 12);
            Console.WriteLine(pt.ToString());
        }
    }
}
=======
﻿using System;

namespace Struct
{
   
    class Program
    {
        struct MyPoint
        {
            public int X;
            public int Y;

            public MyPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0},{1})", X, Y);
            }
        }
        static void Main(string[] args)
        {
            MyPoint pt = new MyPoint(10, 12);
            Console.WriteLine(pt.ToString());
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
