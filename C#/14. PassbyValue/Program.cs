﻿using System;

namespace PassbyValue
{
    
    class Program
    {
        private int Calculate(int a)
        {
            a *= 2;
            return a;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            // val의 value가 안바뀜
            int val = 100;
            int val2 = p.Calculate(val);
            Console.WriteLine("val :");
            Console.WriteLine(val);
            Console.WriteLine("p.calculate :");
            Console.WriteLine(val2);
        }
    }
}