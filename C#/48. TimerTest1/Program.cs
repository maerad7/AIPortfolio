<<<<<<< HEAD
﻿using System;
using System.IO;
using System.Net;
using System.Timers;

namespace TimerTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new System.Timers.Timer();
            timer.Interval = 60 * 60 * 1000; // 1시간
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        // 쓰레드풀의 작업쓰레드가 지정된 time interval로 아래 이벤트 핸들러 실행
        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // 웹 페이지 html문을 다운로드
            WebClient web = new WebClient();
            string webpage = web.DownloadString("https://mssql.tools");

            // 다운로드 내용을 파일에 저장
            string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string outputFile = string.Format("page_{0}.html",time);
            File.WriteAllText(outputFile, webpage);
        }
    }
}
=======
﻿using System;
using System.IO;
using System.Net;
using System.Timers;

namespace TimerTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new System.Timers.Timer();
            timer.Interval = 60 * 60 * 1000; // 1시간
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        // 쓰레드풀의 작업쓰레드가 지정된 time interval로 아래 이벤트 핸들러 실행
        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // 웹 페이지 html문을 다운로드
            WebClient web = new WebClient();
            string webpage = web.DownloadString("https://mssql.tools");

            // 다운로드 내용을 파일에 저장
            string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string outputFile = string.Format("page_{0}.html",time);
            File.WriteAllText(outputFile, webpage);
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
