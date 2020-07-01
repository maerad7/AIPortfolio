using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // value type
            
            bool b = true;
            
            short sh = 100; // 16bit
         
            int i = 100; // 32bit

            long l = 10000L; // 64bit signed integer 
            
            ushort us = 111; // unsigned

            uint ui = 222u; // unsigned

            ulong ul = 3333ul; // unsigned

            float f = 3.14f; // 32bit

            double d = 3.14324232d; // 64bit

            decimal dd = 1231231m; // 128bit

            // 하나일 대 단일 부호
            char ch = 'A'; // 16bit Unicode

            char ch1 = '한';

            byte by = 0x46; // 8bit
            
            // reference type
            
            string s = "Hello";

            object o = "aaa"; // 모든 데이터를 넣을 수 있음(객체)

            string s_null = null;

            object o_null = null;

            // C# 에서 데이터 타입은 value와 reference 타입으로 나누어 진다.
            // reference type 은 null 지정 가능
            
            //자료형 뒤에 ?를 붙이면 null 지정 가능
            int? ix = null;

            if (ix == null)
            {
                Console.WriteLine("ix is null");
                // Console.WriteLine(b);
                // Console.WriteLine(i);
                // Console.WriteLine(l);
                // Console.WriteLine(us);
                // Console.WriteLine(ui);
                // Console.WriteLine(ul);
                // Console.WriteLine(f);
                // Console.WriteLine(d);
                // Console.WriteLine(dd);
                // Console.WriteLine(ch);;
                // Console.WriteLine(ch1);
                // Console.WriteLine(by);
                // Console.WriteLine(s);
                // Console.WriteLine(s_null);
                // Console.WriteLine(o_null);
                // Console.WriteLine(sh);
            }
            else{
                Console.WriteLine(ix.Value);
            }
        }
    }
}