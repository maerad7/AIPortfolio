<<<<<<< HEAD
﻿using System;
using System.Threading;

namespace _58._CountdownEventTest
{
    class Program
    {
        // CountdownEvent 객체 필드(5개의 신호가 도착하는 대로 실행)
        static CountdownEvent countdownEvent = new CountdownEvent(5);
        static void Main(string[] args)
        {
            // 10개 쓰레드 시작, 5개만 Vote만 끝내면 중지
            for(int i = 0; i < 10; i++)
            {
                new Thread(Vote).Start(i);
            }
            countdownEvent.Wait();

            Console.WriteLine("Vote is done!");
        }

        static void Vote(object id)
        {
            if (countdownEvent.CurrentCount > 0)
            {
                // CountdownEvent 신호. -1씩 카운트 다운.
                countdownEvent.Signal();

                Console.WriteLine("{0}: Vote", id);
            }
            else
            {
                Console.WriteLine("{0}: No vote", id);
            }
        }
    }
}
=======
﻿using System;
using System.Threading;

namespace _58._CountdownEventTest
{
    class Program
    {
        // CountdownEvent 객체 필드(5개의 신호가 도착하는 대로 실행)
        static CountdownEvent countdownEvent = new CountdownEvent(5);
        static void Main(string[] args)
        {
            // 10개 쓰레드 시작, 5개만 Vote만 끝내면 중지
            for(int i = 0; i < 10; i++)
            {
                new Thread(Vote).Start(i);
            }
            countdownEvent.Wait();

            Console.WriteLine("Vote is done!");
        }

        static void Vote(object id)
        {
            if (countdownEvent.CurrentCount > 0)
            {
                // CountdownEvent 신호. -1씩 카운트 다운.
                countdownEvent.Signal();

                Console.WriteLine("{0}: Vote", id);
            }
            else
            {
                Console.WriteLine("{0}: No vote", id);
            }
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
