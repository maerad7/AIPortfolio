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
