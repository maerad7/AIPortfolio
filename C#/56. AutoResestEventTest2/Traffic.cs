using System;
using System.Threading;
using System.Collections.Generic;

namespace AutoResestEventTest2
{
    public class Traffic
    {
        private bool _running = true;

        // 상하, 좌우 통행 신호 역할을 하는 AutoResetEvent 
        private AutoResetEvent _evtVert = new AutoResetEvent(true);
        private AutoResetEvent _evtHoriz = new AutoResetEvent(false);

        private Queue<int> _Qvert = new Queue<int>();
        private Queue<int> _Qhoriz = new Queue<int>();

        // 상하방향의 큐 데이타 처리
        // vertical 방향의 처리 신호(_evtVert)를 받으면 Vertical 큐의 모든 큐 아이템을 처리하고 좌우방향 처리 신호(_evtHoriz)를 보냄
        public void ProcessVertical()
        {
            while(_running)
            {

                // Vertical 방향 처리 신호 기다림
                _evtVert.WaitOne();

                // Vertical 큐의 모든 데이타 처리
                // 큐는 다른 쓰레드에서 엑세스 가능하므로 lock을 건다
                lock (_Qvert)
                {
                    while (_Qvert.Count >0)
                    {
                        int val = _Qvert.Dequeue();
                        Console.WriteLine("Vertical:{0}",val);
                    }
                }
                // Horizontal 방향 처리 신호 보냄
                _evtHoriz.Set();
            }
            Console.WriteLine("ProcessVertical : Done");
        }
        
        // 좌우방향의 큐 데이타 처리
        // Horizontal 방향의 처리 신호(_evtHoriz)를 받으면
        // Horizontal 큐의 모든 큐 아이템을 처리하고
        // 상하방향 처리 신호(_evtHoriz)를 보냄



        public void ProcessHorizontal()
        {
            while (_running)
            {
                _evtHoriz.WaitOne();

                lock(_Qhoriz)
                {
                    while(_Qhoriz.Count>0)
                    {
                        int val = _Qhoriz.Dequeue();
                        Console.WriteLine("Horizontal : {0} ", val);
                    }
                }

                _evtVert.Set();
            }
            Console.WriteLine("ProcessHorizontal : Done");
        }

        public bool Running
        {
            get{ return _running;}
            set{ _running = value;}    
        }

        public void AddVertical(int[] data)
        {
            lock (_Qvert)
            {
                foreach (var item in data)
                {
                    _Qvert.Enqueue(item);
                }
            }
        }

        public void AddHorizontal(int[] data)
        {
            lock ( _Qhoriz)
            {
                foreach(var item in data)
                {
                    _Qhoriz.Enqueue(item);
                }
            }
        }

    }
}