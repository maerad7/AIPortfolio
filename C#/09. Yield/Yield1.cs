<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace _09._Yield
{
    class Program
    {
        static IEnumerable<int> Getnumber()
        {
            yield return 10; // 첫 번째 루프에서 리턴
            yield return 20; // 두 번째 루프에서 리턴
            yield return 30; // 세 번째 루프에서 리턴
        }
        static void Main(string[] args)
        {
            foreach (int num in Getnumber())
            {
                Console.WriteLine(num);
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace _09._Yield
{
    class Program
    {
        static IEnumerable<int> Getnumber()
        {
            yield return 10; // 첫 번째 루프에서 리턴
            yield return 20; // 두 번째 루프에서 리턴
            yield return 30; // 세 번째 루프에서 리턴
        }
        static void Main(string[] args)
        {
            foreach (int num in Getnumber())
            {
                Console.WriteLine(num);
            }
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
