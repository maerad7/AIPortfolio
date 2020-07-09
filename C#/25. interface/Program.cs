using System;

namespace interface1
{
    interface abc
    {
        void xyz();
    }
    class Program : abc
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello World!");
            p.xyz();
        }

        public void xyz()
        {
            Console.WriteLine("xyz!");
        }
    }




}
