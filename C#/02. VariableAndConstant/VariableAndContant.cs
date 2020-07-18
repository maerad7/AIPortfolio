<<<<<<< HEAD
﻿using System;

namespace VariableAndConstant
{
    class VariableAndConstant
    {
         // 전역변수 초기화 하지 않으면 0이 할당된다.
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            int localVar;

            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           VariableAndConstant vc = new VariableAndConstant();
           vc.Method1();
            
        }
    }
}
=======
﻿using System;

namespace VariableAndConstant
{
    class VariableAndConstant
    {
         // 전역변수 초기화 하지 않으면 0이 할당된다.
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            int localVar;

            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           VariableAndConstant vc = new VariableAndConstant();
           vc.Method1();
            
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
