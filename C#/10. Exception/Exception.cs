<<<<<<< HEAD
﻿using System;
using System.IO;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // throw;
            }


            Console.WriteLine("Next Step");
        }

        static void run()
        {
            try
            {

            
            int[] a = new int[11];

            for (int i = 0 ; i <= 10 ;i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }
        

            var fs = File.Open("my.config",FileMode.Open);
            }
            // catch (IndexOutOfRangeException ex)
            // {
            //     Console.WriteLine("배열 범위 밖에 있습니다.");
            // }
            // catch (FileNotFoundException ex)
            // {
            //     Console.WriteLine("파일을 찾을 수 없습니다.");
            // }
            catch (Exception ex)
            {
                Log(ex);
                throw new ApplicationException(ex.Message, ex);
            }
        }

        static void Log(Exception ex)
        {
            //File ,DB 로깅

        }
}
}
=======
﻿using System;
using System.IO;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // throw;
            }


            Console.WriteLine("Next Step");
        }

        static void run()
        {
            try
            {

            
            int[] a = new int[11];

            for (int i = 0 ; i <= 10 ;i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }
        

            var fs = File.Open("my.config",FileMode.Open);
            }
            // catch (IndexOutOfRangeException ex)
            // {
            //     Console.WriteLine("배열 범위 밖에 있습니다.");
            // }
            // catch (FileNotFoundException ex)
            // {
            //     Console.WriteLine("파일을 찾을 수 없습니다.");
            // }
            catch (Exception ex)
            {
                Log(ex);
                throw new ApplicationException(ex.Message, ex);
            }
        }

        static void Log(Exception ex)
        {
            //File ,DB 로깅

        }
}
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
