using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
               
            var t = new { Name="홍길동", Age=20 };
            string s = t.Name;
        }
    }
}
