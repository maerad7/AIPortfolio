<<<<<<< HEAD
﻿using System;

namespace StaticCalss
{
    public static class MyUtility
    {
        private static int ver;
        static MyUtility()
        {
            ver = 1 ;
        }

        public static string Convert(int i)
        {
            return i.ToString();
        }

        public static int ConvertBack(string s)
        {
            return int.Parse(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = MyUtility.Convert(123);
            int i = MyUtility.ConvertBack(str);
        }
    }
}
=======
﻿using System;

namespace StaticCalss
{
    public static class MyUtility
    {
        private static int ver;
        static MyUtility()
        {
            ver = 1 ;
        }

        public static string Convert(int i)
        {
            return i.ToString();
        }

        public static int ConvertBack(string s)
        {
            return int.Parse(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = MyUtility.Convert(123);
            int i = MyUtility.ConvertBack(str);
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
