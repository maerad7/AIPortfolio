using System;

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
