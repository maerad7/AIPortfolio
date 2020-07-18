﻿using System;

namespace LambDa
{
    class Program
    {
        static void Main(string[] args)
        {
            // 입력 파라미터가 없는 경우
            () => Write("No");

            // 입력 파라미터가 1~2개 있는 경우
            (p) => Write(p);
            (s, e) => { Write(s); Write(e); };

            // 입력 파라미터 타입을 명시하는 경우
            (string s, int i) => Write(s, i);
        }
    }
}
