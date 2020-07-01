﻿using System;
using System.Collections.Generic;

namespace Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> keyList = new List<char>();
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();
                keyList.Add(key.KeyChar);
            }
            while( key.Key != ConsoleKey.Q); // Q가 아니면 계속

            Console.WriteLine();

            foreach(char ch in keyList)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
